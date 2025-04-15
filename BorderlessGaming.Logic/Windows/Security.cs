using System.Security.Cryptography;
using System.Text.Json;
using BorderlessGaming.Logic.Models;
using BorderlessGaming.Logic.System;
using ProtoBuf;

namespace BorderlessGaming.Logic.Windows
{
    public static class Security
    {
        private static readonly byte[] Salt = { 0x33, 0x92, 0x91, 0x12, 0x28, 0x19 };

        public static byte[] Encrypt(byte[] plainText)
        {
            return ProtectedData.Protect(plainText, Salt, DataProtectionScope.CurrentUser);
        }

        public static byte[] Decrypt(byte[] cipher)
        {
            return ProtectedData.Unprotect(cipher, Salt, DataProtectionScope.CurrentUser);
        }

        /// <summary>
        ///     Encrypts the config file, I've seen a trend of people mining the Borderless Gaming favorites list for heuristics.
        /// </summary>
        /// <param name="instance"></param>
        public static void SaveConfig(Config instance)
        {
            try
            {
                string json = JsonSerializer.Serialize(instance, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(AppEnvironment.ConfigPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving config: {ex.Message}");
            }
        }

        public static Config LoadConfigFile()
        {
            try
            {
                if (!File.Exists(AppEnvironment.ConfigPath))
                {
                    SaveConfig(new Config());
                }

                string json = File.ReadAllText(AppEnvironment.ConfigPath);
                return JsonSerializer.Deserialize<Config>(json) ?? new Config();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading config: {ex.Message}");
                File.Delete(AppEnvironment.ConfigPath);
                SaveConfig(new Config());
                return LoadConfigFile();
            }
        }
    }
}