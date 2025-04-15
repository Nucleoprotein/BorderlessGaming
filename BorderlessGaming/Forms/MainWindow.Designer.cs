using BorderlessGaming.Logic.Core;
using BorderlessGaming.Properties;

namespace BorderlessGaming.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btnMakeBorderless = new Button();
            lstProcesses = new ListBox();
            processContext = new ContextMenuStrip(components);
            contextAddToFavs = new ToolStripMenuItem();
            toolStripByTheWindowTitle = new ToolStripMenuItem();
            toolStripByRegex = new ToolStripMenuItem();
            toolStripByProcess = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            contextBorderless = new ToolStripMenuItem();
            contextBorderlessOn = new ToolStripMenuItem();
            toolStripSetWindowTitle = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripSeparator();
            toolStripHideProcess = new ToolStripMenuItem();
            contextFavScreen = new ToolStripMenuItem();
            addSelectedItem = new Button();
            lstFavorites = new ListBox();
            mnuFavoritesContext = new ContextMenuStrip(components);
            toolStripFullScreen = new ToolStripMenuItem();
            toolStripNoSizeChange = new ToolStripMenuItem();
            toolStripSetSetWindowSize = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            toolStripAutomaximize = new ToolStripMenuItem();
            toolStripAdjustWindowBounds = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            toolStripAlwaysOnTop = new ToolStripMenuItem();
            toolStripDelayBorderless = new ToolStripMenuItem();
            toolStripHideMouseCursor = new ToolStripMenuItem();
            toolStripHideWindowsTaskbar = new ToolStripMenuItem();
            toolStripRemoveMenus = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripSeparator();
            toolStripMuteInBackground = new ToolStripMenuItem();
            contextRemoveFromFavs = new ToolStripMenuItem();
            btnRemoveFavorite = new Button();
            processLabel = new Label();
            favoritesLabel = new Label();
            trayIcon = new NotifyIcon(components);
            trayIconContextMenu = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mnuMain = new MenuStrip();
            toolStripOptions = new ToolStripMenuItem();
            toolStripRunOnStartup = new ToolStripMenuItem();
            toolStripLanguages = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            toolStripGlobalHotkey = new ToolStripMenuItem();
            toolStripMouseLock = new ToolStripMenuItem();
            toolStripMouseHide = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            toolStripMinimizedToTray = new ToolStripMenuItem();
            toolStripCloseToTray = new ToolStripMenuItem();
            toolStripHideBalloonTips = new ToolStripMenuItem();
            toolStripSlowWindowDetection = new ToolStripMenuItem();
            toolStripViewFullProcessDetails = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripSeparator();
            toolStripRestoreProcesses = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            toolStripPauseAutomaticProcessing = new ToolStripMenuItem();
            toolStripOpenDataFolder = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripSeparator();
            toolStripToggleMouseCursorVisibility = new ToolStripMenuItem();
            toolStripToggleWindowsTaskbar = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripSeparator();
            toolStripFullApplicationRefresh = new ToolStripMenuItem();
            toolStripInfo = new ToolStripMenuItem();
            toolStripUsageGuide = new ToolStripMenuItem();
            toolStripRegexReference = new ToolStripMenuItem();
            toolStripMenuItem13 = new ToolStripSeparator();
            toolStripReportBug = new ToolStripMenuItem();
            toolStripSupportUs = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            toolStripAbout = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRestoreWindow = new Button();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            processContext.SuspendLayout();
            mnuFavoritesContext.SuspendLayout();
            trayIconContextMenu.SuspendLayout();
            mnuMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMakeBorderless
            // 
            resources.ApplyResources(btnMakeBorderless, "btnMakeBorderless");
            btnMakeBorderless.Image = Resources.borderless;
            btnMakeBorderless.Name = "btnMakeBorderless";
            btnMakeBorderless.UseVisualStyleBackColor = true;
            btnMakeBorderless.Click += btnMakeBorderless_Click;
            btnMakeBorderless.MouseHover += btnMakeBorderless_MouseHover;
            // 
            // lstProcesses
            // 
            resources.ApplyResources(lstProcesses, "lstProcesses");
            lstProcesses.ContextMenuStrip = processContext;
            lstProcesses.FormattingEnabled = true;
            lstProcesses.Name = "lstProcesses";
            lstProcesses.Sorted = true;
            lstProcesses.SelectedIndexChanged += lstProcesses_SelectedIndexChanged;
            // 
            // processContext
            // 
            resources.ApplyResources(processContext, "processContext");
            processContext.Items.AddRange(new ToolStripItem[] { contextAddToFavs, toolStripMenuItem1, contextBorderless, contextBorderlessOn, toolStripSetWindowTitle, toolStripMenuItem8, toolStripHideProcess });
            processContext.Name = "processContext";
            processContext.Opening += processContext_Opening;
            // 
            // contextAddToFavs
            // 
            resources.ApplyResources(contextAddToFavs, "contextAddToFavs");
            contextAddToFavs.DropDownItems.AddRange(new ToolStripItem[] { toolStripByTheWindowTitle, toolStripByRegex, toolStripByProcess });
            contextAddToFavs.Name = "contextAddToFavs";
            // 
            // toolStripByTheWindowTitle
            // 
            resources.ApplyResources(toolStripByTheWindowTitle, "toolStripByTheWindowTitle");
            toolStripByTheWindowTitle.Name = "toolStripByTheWindowTitle";
            toolStripByTheWindowTitle.Click += byTheWindowTitleTextToolStripMenuItem_Click;
            // 
            // toolStripByRegex
            // 
            resources.ApplyResources(toolStripByRegex, "toolStripByRegex");
            toolStripByRegex.Name = "toolStripByRegex";
            toolStripByRegex.Click += byTheWindowTitleTextregexToolStripMenuItem_Click;
            // 
            // toolStripByProcess
            // 
            resources.ApplyResources(toolStripByProcess, "toolStripByProcess");
            toolStripByProcess.Name = "toolStripByProcess";
            toolStripByProcess.Click += byTheProcessBinaryNameToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // contextBorderless
            // 
            resources.ApplyResources(contextBorderless, "contextBorderless");
            contextBorderless.Name = "contextBorderless";
            contextBorderless.Click += btnMakeBorderless_Click;
            // 
            // contextBorderlessOn
            // 
            resources.ApplyResources(contextBorderlessOn, "contextBorderlessOn");
            contextBorderlessOn.Name = "contextBorderlessOn";
            // 
            // toolStripSetWindowTitle
            // 
            resources.ApplyResources(toolStripSetWindowTitle, "toolStripSetWindowTitle");
            toolStripSetWindowTitle.Name = "toolStripSetWindowTitle";
            toolStripSetWindowTitle.Click += setWindowTitleToolStripMenuItem_Click;
            // 
            // toolStripMenuItem8
            // 
            resources.ApplyResources(toolStripMenuItem8, "toolStripMenuItem8");
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            // 
            // toolStripHideProcess
            // 
            resources.ApplyResources(toolStripHideProcess, "toolStripHideProcess");
            toolStripHideProcess.Name = "toolStripHideProcess";
            toolStripHideProcess.Click += hideThisProcessToolStripMenuItem_Click;
            // 
            // contextFavScreen
            // 
            resources.ApplyResources(contextFavScreen, "contextFavScreen");
            contextFavScreen.Name = "contextFavScreen";
            // 
            // addSelectedItem
            // 
            resources.ApplyResources(addSelectedItem, "addSelectedItem");
            addSelectedItem.Image = Resources.add;
            addSelectedItem.Name = "addSelectedItem";
            addSelectedItem.UseVisualStyleBackColor = true;
            addSelectedItem.Click += addSelectedItem_Click;
            addSelectedItem.MouseHover += addSelectedItem_MouseHover;
            // 
            // lstFavorites
            // 
            resources.ApplyResources(lstFavorites, "lstFavorites");
            lstFavorites.ContextMenuStrip = mnuFavoritesContext;
            lstFavorites.FormattingEnabled = true;
            lstFavorites.Name = "lstFavorites";
            lstFavorites.Sorted = true;
            lstFavorites.SelectedIndexChanged += lstFavorites_SelectedIndexChanged;
            // 
            // mnuFavoritesContext
            // 
            resources.ApplyResources(mnuFavoritesContext, "mnuFavoritesContext");
            mnuFavoritesContext.Items.AddRange(new ToolStripItem[] { toolStripFullScreen, toolStripNoSizeChange, toolStripSetSetWindowSize, toolStripMenuItem6, toolStripAutomaximize, toolStripAdjustWindowBounds, toolStripMenuItem4, toolStripAlwaysOnTop, toolStripDelayBorderless, toolStripHideMouseCursor, toolStripHideWindowsTaskbar, toolStripRemoveMenus, toolStripMenuItem9, contextFavScreen, toolStripMuteInBackground, contextRemoveFromFavs });
            mnuFavoritesContext.Name = "mnuFavoritesRightClick";
            mnuFavoritesContext.Opening += mnuFavoritesContext_Opening;
            // 
            // toolStripFullScreen
            // 
            resources.ApplyResources(toolStripFullScreen, "toolStripFullScreen");
            toolStripFullScreen.CheckOnClick = true;
            toolStripFullScreen.Name = "toolStripFullScreen";
            toolStripFullScreen.Click += fullScreenToolStripMenuItem_Click;
            // 
            // toolStripNoSizeChange
            // 
            resources.ApplyResources(toolStripNoSizeChange, "toolStripNoSizeChange");
            toolStripNoSizeChange.CheckOnClick = true;
            toolStripNoSizeChange.Name = "toolStripNoSizeChange";
            toolStripNoSizeChange.Click += noSizeChangeToolStripMenuItem_Click;
            // 
            // toolStripSetSetWindowSize
            // 
            resources.ApplyResources(toolStripSetSetWindowSize, "toolStripSetSetWindowSize");
            toolStripSetSetWindowSize.Name = "toolStripSetSetWindowSize";
            toolStripSetSetWindowSize.Click += setWindowSizeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(toolStripMenuItem6, "toolStripMenuItem6");
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            // 
            // toolStripAutomaximize
            // 
            resources.ApplyResources(toolStripAutomaximize, "toolStripAutomaximize");
            toolStripAutomaximize.CheckOnClick = true;
            toolStripAutomaximize.Name = "toolStripAutomaximize";
            toolStripAutomaximize.Click += automaximizeToolStripMenuItem_Click;
            // 
            // toolStripAdjustWindowBounds
            // 
            resources.ApplyResources(toolStripAdjustWindowBounds, "toolStripAdjustWindowBounds");
            toolStripAdjustWindowBounds.Name = "toolStripAdjustWindowBounds";
            toolStripAdjustWindowBounds.Click += adjustWindowBoundsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(toolStripMenuItem4, "toolStripMenuItem4");
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // toolStripAlwaysOnTop
            // 
            resources.ApplyResources(toolStripAlwaysOnTop, "toolStripAlwaysOnTop");
            toolStripAlwaysOnTop.CheckOnClick = true;
            toolStripAlwaysOnTop.Name = "toolStripAlwaysOnTop";
            toolStripAlwaysOnTop.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // toolStripDelayBorderless
            // 
            resources.ApplyResources(toolStripDelayBorderless, "toolStripDelayBorderless");
            toolStripDelayBorderless.CheckOnClick = true;
            toolStripDelayBorderless.Name = "toolStripDelayBorderless";
            toolStripDelayBorderless.Click += delayBorderlessToolStripMenuItem_Click;
            // 
            // toolStripHideMouseCursor
            // 
            resources.ApplyResources(toolStripHideMouseCursor, "toolStripHideMouseCursor");
            toolStripHideMouseCursor.CheckOnClick = true;
            toolStripHideMouseCursor.Name = "toolStripHideMouseCursor";
            toolStripHideMouseCursor.Click += hideMouseCursorToolStripMenuItem_Click;
            // 
            // toolStripHideWindowsTaskbar
            // 
            resources.ApplyResources(toolStripHideWindowsTaskbar, "toolStripHideWindowsTaskbar");
            toolStripHideWindowsTaskbar.CheckOnClick = true;
            toolStripHideWindowsTaskbar.Name = "toolStripHideWindowsTaskbar";
            toolStripHideWindowsTaskbar.Click += hideWindowsTaskbarToolStripMenuItem_Click;
            // 
            // toolStripRemoveMenus
            // 
            resources.ApplyResources(toolStripRemoveMenus, "toolStripRemoveMenus");
            toolStripRemoveMenus.CheckOnClick = true;
            toolStripRemoveMenus.Name = "toolStripRemoveMenus";
            toolStripRemoveMenus.Click += removeMenusToolStripMenuItem_Click;
            // 
            // toolStripMenuItem9
            // 
            resources.ApplyResources(toolStripMenuItem9, "toolStripMenuItem9");
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            // 
            // toolStripMuteInBackground
            // 
            resources.ApplyResources(toolStripMuteInBackground, "toolStripMuteInBackground");
            toolStripMuteInBackground.CheckOnClick = true;
            toolStripMuteInBackground.Name = "toolStripMuteInBackground";
            toolStripMuteInBackground.Click += muteInBackgroundToolStripMenuItem_Click;
            // 
            // contextRemoveFromFavs
            // 
            resources.ApplyResources(contextRemoveFromFavs, "contextRemoveFromFavs");
            contextRemoveFromFavs.Name = "contextRemoveFromFavs";
            contextRemoveFromFavs.Click += btnRemoveFavorite_Click;
            // 
            // btnRemoveFavorite
            // 
            resources.ApplyResources(btnRemoveFavorite, "btnRemoveFavorite");
            btnRemoveFavorite.Image = Resources.remove;
            btnRemoveFavorite.Name = "btnRemoveFavorite";
            btnRemoveFavorite.UseVisualStyleBackColor = true;
            btnRemoveFavorite.Click += btnRemoveFavorite_Click;
            btnRemoveFavorite.MouseHover += btnRemoveFavorite_MouseHover;
            // 
            // processLabel
            // 
            resources.ApplyResources(processLabel, "processLabel");
            processLabel.Name = "processLabel";
            // 
            // favoritesLabel
            // 
            resources.ApplyResources(favoritesLabel, "favoritesLabel");
            favoritesLabel.Name = "favoritesLabel";
            // 
            // trayIcon
            // 
            resources.ApplyResources(trayIcon, "trayIcon");
            trayIcon.ContextMenuStrip = trayIconContextMenu;
            trayIcon.DoubleClick += trayIcon_DoubleClick;
            // 
            // trayIconContextMenu
            // 
            resources.ApplyResources(trayIconContextMenu, "trayIconContextMenu");
            trayIconContextMenu.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripMenuItem7, exitToolStripMenuItem });
            trayIconContextMenu.Name = "trayIconContextMenu";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Click += trayIcon_DoubleClick;
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(toolStripMenuItem7, "toolStripMenuItem7");
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // mnuMain
            // 
            resources.ApplyResources(mnuMain, "mnuMain");
            mnuMain.Items.AddRange(new ToolStripItem[] { toolStripOptions, toolsToolStripMenuItem, toolStripInfo });
            mnuMain.Name = "mnuMain";
            // 
            // toolStripOptions
            // 
            resources.ApplyResources(toolStripOptions, "toolStripOptions");
            toolStripOptions.DropDownItems.AddRange(new ToolStripItem[] { toolStripRunOnStartup, toolStripLanguages, toolStripMenuItem3, toolStripGlobalHotkey, toolStripMouseLock, toolStripMouseHide, toolStripMenuItem5, toolStripMinimizedToTray, toolStripCloseToTray, toolStripHideBalloonTips, toolStripSlowWindowDetection, toolStripViewFullProcessDetails, toolStripMenuItem10, toolStripRestoreProcesses });
            toolStripOptions.Name = "toolStripOptions";
            // 
            // toolStripRunOnStartup
            // 
            resources.ApplyResources(toolStripRunOnStartup, "toolStripRunOnStartup");
            toolStripRunOnStartup.CheckOnClick = true;
            toolStripRunOnStartup.Name = "toolStripRunOnStartup";
            toolStripRunOnStartup.CheckedChanged += toolStripRunOnStartup_CheckChanged;
            // 
            // toolStripLanguages
            // 
            resources.ApplyResources(toolStripLanguages, "toolStripLanguages");
            toolStripLanguages.Name = "toolStripLanguages";
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(toolStripMenuItem3, "toolStripMenuItem3");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // toolStripGlobalHotkey
            // 
            resources.ApplyResources(toolStripGlobalHotkey, "toolStripGlobalHotkey");
            toolStripGlobalHotkey.CheckOnClick = true;
            toolStripGlobalHotkey.Name = "toolStripGlobalHotkey";
            toolStripGlobalHotkey.CheckedChanged += toolStripGlobalHotkey_CheckChanged;
            // 
            // toolStripMouseLock
            // 
            resources.ApplyResources(toolStripMouseLock, "toolStripMouseLock");
            toolStripMouseLock.CheckOnClick = true;
            toolStripMouseLock.Name = "toolStripMouseLock";
            toolStripMouseLock.CheckedChanged += toolStripMouseLock_CheckChanged;
            // 
            // toolStripMouseHide
            // 
            resources.ApplyResources(toolStripMouseHide, "toolStripMouseHide");
            toolStripMouseHide.CheckOnClick = true;
            toolStripMouseHide.Name = "toolStripMouseHide";
            toolStripMouseHide.CheckedChanged += useMouseHideHotkeyWinScrollLockToolStripMenuItem_CheckChanged;
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(toolStripMenuItem5, "toolStripMenuItem5");
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // toolStripMinimizedToTray
            // 
            resources.ApplyResources(toolStripMinimizedToTray, "toolStripMinimizedToTray");
            toolStripMinimizedToTray.CheckOnClick = true;
            toolStripMinimizedToTray.Name = "toolStripMinimizedToTray";
            toolStripMinimizedToTray.CheckedChanged += startMinimizedToTrayToolStripMenuItem_CheckedChanged;
            // 
            // toolStripCloseToTray
            // 
            resources.ApplyResources(toolStripCloseToTray, "toolStripCloseToTray");
            toolStripCloseToTray.CheckOnClick = true;
            toolStripCloseToTray.Name = "toolStripCloseToTray";
            toolStripCloseToTray.CheckedChanged += closeToTrayToolStripMenuItem_CheckedChanged;
            // 
            // toolStripHideBalloonTips
            // 
            resources.ApplyResources(toolStripHideBalloonTips, "toolStripHideBalloonTips");
            toolStripHideBalloonTips.CheckOnClick = true;
            toolStripHideBalloonTips.Name = "toolStripHideBalloonTips";
            toolStripHideBalloonTips.CheckedChanged += hideBalloonTipsToolStripMenuItem_CheckedChanged;
            // 
            // toolStripSlowWindowDetection
            // 
            resources.ApplyResources(toolStripSlowWindowDetection, "toolStripSlowWindowDetection");
            toolStripSlowWindowDetection.CheckOnClick = true;
            toolStripSlowWindowDetection.Name = "toolStripSlowWindowDetection";
            toolStripSlowWindowDetection.Click += useSlowerWindowDetectionToolStripMenuItem_Click;
            // 
            // toolStripViewFullProcessDetails
            // 
            resources.ApplyResources(toolStripViewFullProcessDetails, "toolStripViewFullProcessDetails");
            toolStripViewFullProcessDetails.CheckOnClick = true;
            toolStripViewFullProcessDetails.Name = "toolStripViewFullProcessDetails";
            toolStripViewFullProcessDetails.CheckedChanged += viewFullProcessDetailsToolStripMenuItem_CheckedChanged;
            // 
            // toolStripMenuItem10
            // 
            resources.ApplyResources(toolStripMenuItem10, "toolStripMenuItem10");
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            // 
            // toolStripRestoreProcesses
            // 
            resources.ApplyResources(toolStripRestoreProcesses, "toolStripRestoreProcesses");
            toolStripRestoreProcesses.Name = "toolStripRestoreProcesses";
            toolStripRestoreProcesses.Click += resetHiddenProcessesToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            resources.ApplyResources(toolsToolStripMenuItem, "toolsToolStripMenuItem");
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripPauseAutomaticProcessing, toolStripOpenDataFolder, toolStripMenuItem11, toolStripToggleMouseCursorVisibility, toolStripToggleWindowsTaskbar, toolStripMenuItem12, toolStripFullApplicationRefresh });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            // 
            // toolStripPauseAutomaticProcessing
            // 
            resources.ApplyResources(toolStripPauseAutomaticProcessing, "toolStripPauseAutomaticProcessing");
            toolStripPauseAutomaticProcessing.CheckOnClick = true;
            toolStripPauseAutomaticProcessing.Name = "toolStripPauseAutomaticProcessing";
            toolStripPauseAutomaticProcessing.Click += pauseAutomaticProcessingToolStripMenuItem_Click;
            // 
            // toolStripOpenDataFolder
            // 
            resources.ApplyResources(toolStripOpenDataFolder, "toolStripOpenDataFolder");
            toolStripOpenDataFolder.Name = "toolStripOpenDataFolder";
            toolStripOpenDataFolder.Click += openDataFolderToolStripMenuItem_Click;
            // 
            // toolStripMenuItem11
            // 
            resources.ApplyResources(toolStripMenuItem11, "toolStripMenuItem11");
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            // 
            // toolStripToggleMouseCursorVisibility
            // 
            resources.ApplyResources(toolStripToggleMouseCursorVisibility, "toolStripToggleMouseCursorVisibility");
            toolStripToggleMouseCursorVisibility.Name = "toolStripToggleMouseCursorVisibility";
            toolStripToggleMouseCursorVisibility.Click += toggleMouseCursorVisibilityToolStripMenuItem_Click;
            // 
            // toolStripToggleWindowsTaskbar
            // 
            resources.ApplyResources(toolStripToggleWindowsTaskbar, "toolStripToggleWindowsTaskbar");
            toolStripToggleWindowsTaskbar.Name = "toolStripToggleWindowsTaskbar";
            toolStripToggleWindowsTaskbar.Click += toggleWindowsTaskbarVisibilityToolStripMenuItem_Click;
            // 
            // toolStripMenuItem12
            // 
            resources.ApplyResources(toolStripMenuItem12, "toolStripMenuItem12");
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            // 
            // toolStripFullApplicationRefresh
            // 
            resources.ApplyResources(toolStripFullApplicationRefresh, "toolStripFullApplicationRefresh");
            toolStripFullApplicationRefresh.Name = "toolStripFullApplicationRefresh";
            toolStripFullApplicationRefresh.Click += fullApplicationRefreshToolStripMenuItem_Click;
            // 
            // toolStripInfo
            // 
            resources.ApplyResources(toolStripInfo, "toolStripInfo");
            toolStripInfo.DropDownItems.AddRange(new ToolStripItem[] { toolStripUsageGuide, toolStripRegexReference, toolStripMenuItem13, toolStripReportBug, toolStripSupportUs, toolStripMenuItem2, toolStripAbout });
            toolStripInfo.Name = "toolStripInfo";
            // 
            // toolStripUsageGuide
            // 
            resources.ApplyResources(toolStripUsageGuide, "toolStripUsageGuide");
            toolStripUsageGuide.Name = "toolStripUsageGuide";
            toolStripUsageGuide.Click += usageGuideToolStripMenuItem_Click;
            // 
            // toolStripRegexReference
            // 
            resources.ApplyResources(toolStripRegexReference, "toolStripRegexReference");
            toolStripRegexReference.Name = "toolStripRegexReference";
            toolStripRegexReference.Click += toolStripRegexReference_Click;
            // 
            // toolStripMenuItem13
            // 
            resources.ApplyResources(toolStripMenuItem13, "toolStripMenuItem13");
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            // 
            // toolStripReportBug
            // 
            resources.ApplyResources(toolStripReportBug, "toolStripReportBug");
            toolStripReportBug.Name = "toolStripReportBug";
            toolStripReportBug.Click += toolStripReportBug_Click;
            // 
            // toolStripSupportUs
            // 
            resources.ApplyResources(toolStripSupportUs, "toolStripSupportUs");
            toolStripSupportUs.Name = "toolStripSupportUs";
            toolStripSupportUs.Click += toolStripSupportUs_Click;
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(toolStripMenuItem2, "toolStripMenuItem2");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // toolStripAbout
            // 
            resources.ApplyResources(toolStripAbout, "toolStripAbout");
            toolStripAbout.Name = "toolStripAbout";
            toolStripAbout.Click += toolStripAbout_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(processLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(favoritesLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(lstProcesses, 0, 1);
            tableLayoutPanel1.Controls.Add(lstFavorites, 2, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(addSelectedItem);
            flowLayoutPanel1.Controls.Add(btnRemoveFavorite);
            flowLayoutPanel1.Controls.Add(btnMakeBorderless);
            flowLayoutPanel1.Controls.Add(btnRestoreWindow);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnRestoreWindow
            // 
            resources.ApplyResources(btnRestoreWindow, "btnRestoreWindow");
            btnRestoreWindow.Image = Resources.bordered;
            btnRestoreWindow.Name = "btnRestoreWindow";
            btnRestoreWindow.UseVisualStyleBackColor = true;
            btnRestoreWindow.Click += btnRestoreWindow_Click;
            btnRestoreWindow.MouseHover += btnRestoreWindow_MouseHover;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            // 
            // statusLabel
            // 
            resources.ApplyResources(statusLabel, "statusLabel");
            statusLabel.Name = "statusLabel";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            MaximizeBox = false;
            Name = "MainWindow";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            Shown += MainWindow_Shown;
            Resize += MainWindow_Resize;
            processContext.ResumeLayout(false);
            mnuFavoritesContext.ResumeLayout(false);
            trayIconContextMenu.ResumeLayout(false);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeBorderless;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button addSelectedItem;
        private System.Windows.Forms.ListBox lstFavorites;
        private System.Windows.Forms.Button btnRemoveFavorite;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label favoritesLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripRunOnStartup;
        private System.Windows.Forms.ToolStripMenuItem toolStripInfo;
        private System.Windows.Forms.ToolStripMenuItem rainwayStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripReportBug;
        private System.Windows.Forms.ToolStripMenuItem toolStripSupportUs;
        private System.Windows.Forms.ToolStripMenuItem toolStripRegexReference;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip processContext;
        private System.Windows.Forms.ToolStripMenuItem contextAddToFavs;
        private System.Windows.Forms.ToolStripMenuItem contextBorderless;
        private System.Windows.Forms.ToolStripMenuItem contextBorderlessOn;
        private System.Windows.Forms.ToolStripMenuItem contextFavScreen;
        private System.Windows.Forms.ContextMenuStrip mnuFavoritesContext;
        private System.Windows.Forms.ToolStripMenuItem contextRemoveFromFavs;
        private System.Windows.Forms.ToolStripMenuItem toolStripGlobalHotkey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripByTheWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripByProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripByRegex;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdjustWindowBounds;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripAutomaximize;
        private System.Windows.Forms.Button btnRestoreWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMinimizedToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripCloseToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideBalloonTips;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;//this might get replaced if you redo anything in the form designer
        private System.Windows.Forms.ToolStripMenuItem toolStripViewFullProcessDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetSetWindowSize;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemoveMenus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelayBorderless;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideMouseCursor;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleMouseCursorVisibility;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseHide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripRestoreProcesses;
        private System.Windows.Forms.ToolStripMenuItem toolStripPauseAutomaticProcessing;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripNoSizeChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpenDataFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullApplicationRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripSlowWindowDetection;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsageGuide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMuteInBackground;
        private System.Windows.Forms.ToolStripMenuItem toolStripLanguages;
    }
}