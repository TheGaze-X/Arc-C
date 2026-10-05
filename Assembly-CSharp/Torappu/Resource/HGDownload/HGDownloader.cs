using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Resource.HGDownload
{
	// Token: 0x02001783 RID: 6019
	[Token(Token = "0x2001783")]
	public class HGDownloader
	{
		// Token: 0x060097CB RID: 38859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097CB")]
		[Address(RVA = "0x3126770", Offset = "0x3125370", VA = "0x183126770")]
		private HGDownloader()
		{
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700104A")]
		public static HGDownloader instance
		{
			[Token(Token = "0x60097CC")]
			[Address(RVA = "0x3126780", Offset = "0x3125380", VA = "0x183126780")]
			get
			{
				return null;
			}
		}

		// Token: 0x060097CD RID: 38861 RVA: 0x0003AF68 File Offset: 0x00039168
		[Token(Token = "0x60097CD")]
		public bool Init<AdapterType>(HGConfig config) where AdapterType : HGDownloader.Adapter, new()
		{
			return default(bool);
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097CE")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public HGDownloader.Adapter GetAdapter()
		{
			return null;
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097CF")]
		[Address(RVA = "0x31257E0", Offset = "0x31243E0", VA = "0x1831257E0")]
		public HGDownloader.TaskHandler StartTask(string versionId, IList<HGFileInfo> files, bool useMobileData)
		{
			return null;
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D0")]
		[Address(RVA = "0x3125510", Offset = "0x3124110", VA = "0x183125510")]
		public void CleanWorkspace()
		{
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D1")]
		[Address(RVA = "0x3125490", Offset = "0x3124090", VA = "0x183125490")]
		public void CancelCurrentTask()
		{
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x0003AF80 File Offset: 0x00039180
		[Token(Token = "0x60097D2")]
		[Address(RVA = "0x31255D0", Offset = "0x31241D0", VA = "0x1831255D0")]
		public bool ManualCheckIfTaskFinished()
		{
			return default(bool);
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x0003AF98 File Offset: 0x00039198
		[Token(Token = "0x60097D3")]
		[Address(RVA = "0x3125580", Offset = "0x3124180", VA = "0x183125580")]
		public HGDownloader.WorkState GetWorkState()
		{
			return HGDownloader.WorkState.IDLE;
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x0003AFB0 File Offset: 0x000391B0
		[Token(Token = "0x60097D4")]
		[Address(RVA = "0x3125380", Offset = "0x3123F80", VA = "0x183125380")]
		public HGDownloadTaskInfo AchieveTaskInfo()
		{
			return default(HGDownloadTaskInfo);
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x0003AFC8 File Offset: 0x000391C8
		[Token(Token = "0x60097D5")]
		[Address(RVA = "0x3125570", Offset = "0x3124170", VA = "0x183125570")]
		public long GetCachedTaskStatus()
		{
			return 0L;
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x0003AFE0 File Offset: 0x000391E0
		[Token(Token = "0x60097D6")]
		[Address(RVA = "0x31254E0", Offset = "0x31240E0", VA = "0x1831254E0")]
		public bool CheckIfInited()
		{
			return default(bool);
		}

		// Token: 0x060097D7 RID: 38871 RVA: 0x0003AFF8 File Offset: 0x000391F8
		[Token(Token = "0x60097D7")]
		[Address(RVA = "0x31252B0", Offset = "0x3123EB0", VA = "0x1831252B0")]
		public long AchieveEstimatedDownloadSizeE(string versionId, IList<HGFileInfo> files, out int errorCode)
		{
			return 0L;
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D8")]
		[Address(RVA = "0x3125680", Offset = "0x3124280", VA = "0x183125680")]
		public void ResumeCurrentTask()
		{
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D9")]
		[Address(RVA = "0x3125540", Offset = "0x3124140", VA = "0x183125540")]
		public void EnableCurrentMobileData()
		{
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DA")]
		[Address(RVA = "0x31259B0", Offset = "0x31245B0", VA = "0x1831259B0")]
		public void Tick()
		{
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DB")]
		[Address(RVA = "0x3126230", Offset = "0x3124E30", VA = "0x183126230")]
		private static void _RaiseSDKInternalError(long errorCode)
		{
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x0003B010 File Offset: 0x00039210
		[Token(Token = "0x60097DC")]
		[Address(RVA = "0x3126620", Offset = "0x3125220", VA = "0x183126620")]
		private bool _TickToCheckIfInited()
		{
			return default(bool);
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x0003B028 File Offset: 0x00039228
		[Token(Token = "0x60097DD")]
		[Address(RVA = "0x3126120", Offset = "0x3124D20", VA = "0x183126120")]
		private static int _InvokeSDKInit(HGDownloader.Adapter adapter, HGConfig config)
		{
			return 0;
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DE")]
		[Address(RVA = "0x3126200", Offset = "0x3124E00", VA = "0x183126200")]
		private void _OnSDKInited()
		{
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x0003B040 File Offset: 0x00039240
		[Token(Token = "0x60097DF")]
		[Address(RVA = "0x3126090", Offset = "0x3124C90", VA = "0x183126090")]
		private bool _CheckIfInited(bool allowIniting)
		{
			return default(bool);
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x0003B058 File Offset: 0x00039258
		[Token(Token = "0x60097E0")]
		[Address(RVA = "0x3126020", Offset = "0x3124C20", VA = "0x183126020")]
		private bool _BreakIfNotInited(bool allowIniting)
		{
			return default(bool);
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x0003B070 File Offset: 0x00039270
		[Token(Token = "0x60097E1")]
		[Address(RVA = "0x3126050", Offset = "0x3124C50", VA = "0x183126050")]
		private static int _CancelTask(long taskId, HGDownloader.Adapter adapter)
		{
			return 0;
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x0003B088 File Offset: 0x00039288
		[Token(Token = "0x60097E2")]
		[Address(RVA = "0x3126290", Offset = "0x3124E90", VA = "0x183126290")]
		private static int _ResumeTask(long taskId, HGDownloader.Adapter adapter)
		{
			return 0;
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x0003B0A0 File Offset: 0x000392A0
		[Token(Token = "0x60097E3")]
		[Address(RVA = "0x3126100", Offset = "0x3124D00", VA = "0x183126100")]
		private static int _EnableMobileData(long taskId, HGDownloader.Adapter adapter)
		{
			return 0;
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x0003B0B8 File Offset: 0x000392B8
		[Token(Token = "0x60097E4")]
		[Address(RVA = "0x31262A0", Offset = "0x3124EA0", VA = "0x1831262A0")]
		private static long _StartDownload(HGDownloader.DownloadTask task, HGDownloader.Adapter adapter)
		{
			return 0L;
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x0003B0D0 File Offset: 0x000392D0
		[Token(Token = "0x60097E5")]
		[Address(RVA = "0x3126110", Offset = "0x3124D10", VA = "0x183126110")]
		private static int _Finish(long taskId, HGDownloader.Adapter adapter)
		{
			return 0;
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x0003B0E8 File Offset: 0x000392E8
		[Token(Token = "0x60097E6")]
		[Address(RVA = "0x31261A0", Offset = "0x3124DA0", VA = "0x1831261A0")]
		private static bool _IsSucCode(long code)
		{
			return default(bool);
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x0003B100 File Offset: 0x00039300
		[Token(Token = "0x60097E7")]
		[Address(RVA = "0x3126060", Offset = "0x3124C60", VA = "0x183126060")]
		private static HGRetCodeType _CheckCodeType(long code)
		{
			return HGRetCodeType.NONE;
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x0003B118 File Offset: 0x00039318
		[Token(Token = "0x60097E8")]
		[Address(RVA = "0x31261F0", Offset = "0x3124DF0", VA = "0x1831261F0")]
		private static bool _IsTaskInvalidCode(long code)
		{
			return default(bool);
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x0003B130 File Offset: 0x00039330
		[Token(Token = "0x60097E9")]
		[Address(RVA = "0x31261E0", Offset = "0x3124DE0", VA = "0x1831261E0")]
		private static bool _IsTaskDuplicatedCode(long code)
		{
			return default(bool);
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x0003B148 File Offset: 0x00039348
		[Token(Token = "0x60097EA")]
		[Address(RVA = "0x31260C0", Offset = "0x3124CC0", VA = "0x1831260C0")]
		private static bool _CreateDirectoryIfNotExists(string folderPath)
		{
			return default(bool);
		}

		// Token: 0x04008DF0 RID: 36336
		[Token(Token = "0x4008DF0")]
		[FieldOffset(Offset = "0x0")]
		private static HGDownloader m_inst;

		// Token: 0x04008DF1 RID: 36337
		[Token(Token = "0x4008DF1")]
		[FieldOffset(Offset = "0x10")]
		private HGDownloader.Adapter m_adapter;

		// Token: 0x04008DF2 RID: 36338
		[Token(Token = "0x4008DF2")]
		[FieldOffset(Offset = "0x18")]
		private HGConfig m_config;

		// Token: 0x04008DF3 RID: 36339
		[Token(Token = "0x4008DF3")]
		[FieldOffset(Offset = "0x20")]
		private HGDownloader.TaskMgr m_taskMgr;

		// Token: 0x04008DF4 RID: 36340
		[Token(Token = "0x4008DF4")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isIniting;

		// Token: 0x04008DF5 RID: 36341
		[Token(Token = "0x4008DF5")]
		[FieldOffset(Offset = "0x2C")]
		private int m_lastInitCode;

		// Token: 0x02001784 RID: 6020
		[Token(Token = "0x2001784")]
		public enum WorkState
		{
			// Token: 0x04008DF7 RID: 36343
			[Token(Token = "0x4008DF7")]
			IDLE,
			// Token: 0x04008DF8 RID: 36344
			[Token(Token = "0x4008DF8")]
			DOWNLOAD,
			// Token: 0x04008DF9 RID: 36345
			[Token(Token = "0x4008DF9")]
			DECOMPRESS,
			// Token: 0x04008DFA RID: 36346
			[Token(Token = "0x4008DFA")]
			COMPLETE,
			// Token: 0x04008DFB RID: 36347
			[Token(Token = "0x4008DFB")]
			ERROR,
			// Token: 0x04008DFC RID: 36348
			[Token(Token = "0x4008DFC")]
			PAUSED,
			// Token: 0x04008DFD RID: 36349
			[Token(Token = "0x4008DFD")]
			UNINITED
		}

		// Token: 0x02001785 RID: 6021
		[Token(Token = "0x2001785")]
		public enum PauseReason
		{
			// Token: 0x04008DFF RID: 36351
			[Token(Token = "0x4008DFF")]
			NONE,
			// Token: 0x04008E00 RID: 36352
			[Token(Token = "0x4008E00")]
			MOBILE_DATA
		}

		// Token: 0x02001786 RID: 6022
		[Token(Token = "0x2001786")]
		public struct DownloadProgress
		{
			// Token: 0x060097EB RID: 38891 RVA: 0x0003B160 File Offset: 0x00039360
			[Token(Token = "0x60097EB")]
			[Address(RVA = "0x3124440", Offset = "0x3123040", VA = "0x183124440")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x060097EC RID: 38892 RVA: 0x0003B178 File Offset: 0x00039378
			[Token(Token = "0x60097EC")]
			[Address(RVA = "0x3124370", Offset = "0x3122F70", VA = "0x183124370")]
			public float GetProgress()
			{
				return 0f;
			}

			// Token: 0x060097ED RID: 38893 RVA: 0x0003B190 File Offset: 0x00039390
			[Token(Token = "0x60097ED")]
			[Address(RVA = "0x3124420", Offset = "0x3123020", VA = "0x183124420")]
			public long GetRemainSize()
			{
				return 0L;
			}

			// Token: 0x04008E01 RID: 36353
			[Token(Token = "0x4008E01")]
			[FieldOffset(Offset = "0x0")]
			public long current;

			// Token: 0x04008E02 RID: 36354
			[Token(Token = "0x4008E02")]
			[FieldOffset(Offset = "0x8")]
			public long total;
		}

		// Token: 0x02001787 RID: 6023
		[Token(Token = "0x2001787")]
		public abstract class Adapter
		{
			// Token: 0x060097EE RID: 38894
			[Token(Token = "0x60097EE")]
			public abstract string ConfigToJson(HGConfig config);

			// Token: 0x060097EF RID: 38895
			[Token(Token = "0x60097EF")]
			public abstract string FileListToJson(IList<HGFileInfo> files);

			// Token: 0x060097F0 RID: 38896
			[Token(Token = "0x60097F0")]
			public abstract string NotificationTitleToJson(HGNotificationTitle titleConfig);

			// Token: 0x060097F1 RID: 38897
			[Token(Token = "0x60097F1")]
			public abstract HGDownloadTaskInfo JsonToTaskInfo(string json);

			// Token: 0x060097F2 RID: 38898
			[Token(Token = "0x60097F2")]
			public abstract bool NeedDecompress();

			// Token: 0x060097F3 RID: 38899
			[Token(Token = "0x60097F3")]
			public abstract string GetDecompressFolder();

			// Token: 0x060097F4 RID: 38900
			[Token(Token = "0x60097F4")]
			public abstract HGDownloadLanType GetLanguageType();

			// Token: 0x060097F5 RID: 38901
			[Token(Token = "0x60097F5")]
			public abstract HGNotificationTitle GetNotificationTitle();

			// Token: 0x060097F6 RID: 38902
			[Token(Token = "0x60097F6")]
			public abstract void LogError(string errorInfo);

			// Token: 0x060097F7 RID: 38903
			[Token(Token = "0x60097F7")]
			public abstract void OnSDKInternalError(int errorCode);

			// Token: 0x060097F8 RID: 38904
			[Token(Token = "0x60097F8")]
			public abstract bool UsePatchMode(out string patchPath);

			// Token: 0x060097F9 RID: 38905 RVA: 0x0003B1A8 File Offset: 0x000393A8
			[Token(Token = "0x60097F9")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
			public virtual bool ValidatePause(HGDownloader.PauseReason reason)
			{
				return default(bool);
			}

			// Token: 0x060097FA RID: 38906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60097FA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected Adapter()
			{
			}
		}

		// Token: 0x02001788 RID: 6024
		[Token(Token = "0x2001788")]
		public class TaskHandler
		{
			// Token: 0x1700104B RID: 4171
			// (get) Token: 0x060097FB RID: 38907 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060097FC RID: 38908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700104B")]
			public Action<HGRetCodeType, int> onError
			{
				[Token(Token = "0x60097FB")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60097FC")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700104C RID: 4172
			// (get) Token: 0x060097FD RID: 38909 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060097FE RID: 38910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700104C")]
			public Action onDownloadFinish
			{
				[Token(Token = "0x60097FD")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60097FE")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700104D RID: 4173
			// (get) Token: 0x060097FF RID: 38911 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009800 RID: 38912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700104D")]
			public Action onDecompressFinish
			{
				[Token(Token = "0x60097FF")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6009800")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700104E RID: 4174
			// (get) Token: 0x06009801 RID: 38913 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009802 RID: 38914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700104E")]
			public Action<HGDownloader.PauseReason> onDownloadPaused
			{
				[Token(Token = "0x6009801")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6009802")]
				[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700104F RID: 4175
			// (get) Token: 0x06009803 RID: 38915 RVA: 0x0003B1C0 File Offset: 0x000393C0
			// (set) Token: 0x06009804 RID: 38916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700104F")]
			public HGDownloader.DownloadProgress downloadProgress
			{
				[Token(Token = "0x6009803")]
				[Address(RVA = "0x312CBB0", Offset = "0x312B7B0", VA = "0x18312CBB0")]
				[CompilerGenerated]
				get
				{
					return default(HGDownloader.DownloadProgress);
				}
				[Token(Token = "0x6009804")]
				[Address(RVA = "0x312CBA0", Offset = "0x312B7A0", VA = "0x18312CBA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001050 RID: 4176
			// (get) Token: 0x06009805 RID: 38917 RVA: 0x0003B1D8 File Offset: 0x000393D8
			// (set) Token: 0x06009806 RID: 38918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001050")]
			public float decompressProgress
			{
				[Token(Token = "0x6009805")]
				[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6009806")]
				[Address(RVA = "0x1692870", Offset = "0x1691470", VA = "0x181692870")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06009807 RID: 38919 RVA: 0x0003B1F0 File Offset: 0x000393F0
			[Token(Token = "0x6009807")]
			[Address(RVA = "0x312CAD0", Offset = "0x312B6D0", VA = "0x18312CAD0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x06009808 RID: 38920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009808")]
			[Address(RVA = "0x312CA90", Offset = "0x312B690", VA = "0x18312CA90")]
			public void Cancel()
			{
			}

			// Token: 0x06009809 RID: 38921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009809")]
			[Address(RVA = "0x312CB40", Offset = "0x312B740", VA = "0x18312CB40")]
			public void MgrOnly_ConsumeDownloadFinish()
			{
			}

			// Token: 0x0600980A RID: 38922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600980A")]
			[Address(RVA = "0x312CB20", Offset = "0x312B720", VA = "0x18312CB20")]
			public void MgrOnly_ConsumeDecompressFinish()
			{
			}

			// Token: 0x0600980B RID: 38923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600980B")]
			[Address(RVA = "0x312CB60", Offset = "0x312B760", VA = "0x18312CB60")]
			public void MgrOnly_InvokePausedCallback(HGDownloader.PauseReason reason)
			{
			}

			// Token: 0x0600980C RID: 38924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600980C")]
			[Address(RVA = "0x312CB80", Offset = "0x312B780", VA = "0x18312CB80")]
			public void MgrOnly_RaiseError(HGRetCodeType codeType, int errorCode)
			{
			}

			// Token: 0x0600980D RID: 38925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600980D")]
			[Address(RVA = "0x312CBA0", Offset = "0x312B7A0", VA = "0x18312CBA0")]
			public void MgrOnly_SetDownloadProg(HGDownloader.DownloadProgress value)
			{
			}

			// Token: 0x0600980E RID: 38926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600980E")]
			[Address(RVA = "0x1692870", Offset = "0x1691470", VA = "0x181692870")]
			public void MgrOnly_SetDecompressProg(float value)
			{
			}

			// Token: 0x0600980F RID: 38927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600980F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TaskHandler()
			{
			}

			// Token: 0x04008E04 RID: 36356
			[Token(Token = "0x4008E04")]
			[FieldOffset(Offset = "0x18")]
			private bool m_downloadFinishConsumed;

			// Token: 0x04008E06 RID: 36358
			[Token(Token = "0x4008E06")]
			[FieldOffset(Offset = "0x28")]
			private bool m_decompressFinishConsumed;
		}

		// Token: 0x02001789 RID: 6025
		[Token(Token = "0x2001789")]
		private class TaskMgr
		{
			// Token: 0x17001051 RID: 4177
			// (get) Token: 0x06009810 RID: 38928 RVA: 0x0003B208 File Offset: 0x00039408
			[Token(Token = "0x17001051")]
			public bool isEmpty
			{
				[Token(Token = "0x6009810")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009811 RID: 38929 RVA: 0x0003B220 File Offset: 0x00039420
			[Token(Token = "0x6009811")]
			[Address(RVA = "0x312CF60", Offset = "0x312BB60", VA = "0x18312CF60")]
			public HGDownloader.DownloadTask GetPendingTask()
			{
				return default(HGDownloader.DownloadTask);
			}

			// Token: 0x06009812 RID: 38930 RVA: 0x0003B238 File Offset: 0x00039438
			[Token(Token = "0x6009812")]
			[Address(RVA = "0x312CF80", Offset = "0x312BB80", VA = "0x18312CF80")]
			public bool HasPendingTask()
			{
				return default(bool);
			}

			// Token: 0x17001052 RID: 4178
			// (get) Token: 0x06009813 RID: 38931 RVA: 0x0003B250 File Offset: 0x00039450
			// (set) Token: 0x06009814 RID: 38932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001052")]
			public long taskId
			{
				[Token(Token = "0x6009813")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6009814")]
				[Address(RVA = "0x1692860", Offset = "0x1691460", VA = "0x181692860")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001053 RID: 4179
			// (get) Token: 0x06009815 RID: 38933 RVA: 0x0003B268 File Offset: 0x00039468
			// (set) Token: 0x06009816 RID: 38934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001053")]
			public long lastTaskStatus
			{
				[Token(Token = "0x6009815")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6009816")]
				[Address(RVA = "0x1692850", Offset = "0x1691450", VA = "0x181692850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001054 RID: 4180
			// (get) Token: 0x06009817 RID: 38935 RVA: 0x0003B280 File Offset: 0x00039480
			// (set) Token: 0x06009818 RID: 38936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001054")]
			public HGDownloader.WorkState currentState
			{
				[Token(Token = "0x6009817")]
				[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
				[CompilerGenerated]
				get
				{
					return HGDownloader.WorkState.IDLE;
				}
				[Token(Token = "0x6009818")]
				[Address(RVA = "0x509F70", Offset = "0x508B70", VA = "0x180509F70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001055 RID: 4181
			// (get) Token: 0x06009819 RID: 38937 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600981A RID: 38938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001055")]
			public HGDownloader.TaskHandler activeTask
			{
				[Token(Token = "0x6009819")]
				[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600981A")]
				[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600981B RID: 38939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600981B")]
			[Address(RVA = "0x312D770", Offset = "0x312C370", VA = "0x18312D770")]
			public TaskMgr(HGDownloader context)
			{
			}

			// Token: 0x0600981C RID: 38940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600981C")]
			[Address(RVA = "0x312D210", Offset = "0x312BE10", VA = "0x18312D210")]
			public void RequestNewTask(HGDownloader.DownloadTask task)
			{
			}

			// Token: 0x0600981D RID: 38941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600981D")]
			[Address(RVA = "0x312D380", Offset = "0x312BF80", VA = "0x18312D380")]
			public void TryStartPendingTask()
			{
			}

			// Token: 0x0600981E RID: 38942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600981E")]
			[Address(RVA = "0x312D050", Offset = "0x312BC50", VA = "0x18312D050")]
			public void MarkDownloadFinish()
			{
			}

			// Token: 0x0600981F RID: 38943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600981F")]
			[Address(RVA = "0x312D370", Offset = "0x312BF70", VA = "0x18312D370")]
			public void StartDecompress()
			{
			}

			// Token: 0x06009820 RID: 38944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009820")]
			[Address(RVA = "0x312D080", Offset = "0x312BC80", VA = "0x18312D080")]
			public void MarkInited()
			{
			}

			// Token: 0x06009821 RID: 38945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009821")]
			[Address(RVA = "0x312CFD0", Offset = "0x312BBD0", VA = "0x18312CFD0")]
			public void MarkComplete()
			{
			}

			// Token: 0x06009822 RID: 38946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009822")]
			[Address(RVA = "0x312D090", Offset = "0x312BC90", VA = "0x18312D090")]
			public void MarkPaused(long pauseCode)
			{
			}

			// Token: 0x06009823 RID: 38947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009823")]
			[Address(RVA = "0x312D140", Offset = "0x312BD40", VA = "0x18312D140")]
			public void NotifyDownloadResumed()
			{
			}

			// Token: 0x06009824 RID: 38948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009824")]
			[Address(RVA = "0x312CE60", Offset = "0x312BA60", VA = "0x18312CE60")]
			public void FinishTask()
			{
			}

			// Token: 0x06009825 RID: 38949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009825")]
			[Address(RVA = "0x312CBC0", Offset = "0x312B7C0", VA = "0x18312CBC0")]
			public void CancelCurrent()
			{
			}

			// Token: 0x06009826 RID: 38950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009826")]
			[Address(RVA = "0x312D250", Offset = "0x312BE50", VA = "0x18312D250")]
			public void ResumeCurrent()
			{
			}

			// Token: 0x06009827 RID: 38951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009827")]
			[Address(RVA = "0x312CCD0", Offset = "0x312B8D0", VA = "0x18312CCD0")]
			public void EnableCurrentMobileData()
			{
			}

			// Token: 0x06009828 RID: 38952 RVA: 0x0003B298 File Offset: 0x00039498
			[Token(Token = "0x6009828")]
			[Address(RVA = "0x312D690", Offset = "0x312C290", VA = "0x18312D690")]
			public bool UpdateTaskStatus(out long taskStatus)
			{
				return default(bool);
			}

			// Token: 0x06009829 RID: 38953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009829")]
			[Address(RVA = "0x312D150", Offset = "0x312BD50", VA = "0x18312D150")]
			public void NotifyTaskError(HGDownloader.TaskHandler target, long errorCode)
			{
			}

			// Token: 0x0600982A RID: 38954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600982A")]
			[Address(RVA = "0x312D5E0", Offset = "0x312C1E0", VA = "0x18312D5E0")]
			public void TrySyncDownloadProgress()
			{
			}

			// Token: 0x0600982B RID: 38955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600982B")]
			[Address(RVA = "0x312D5A0", Offset = "0x312C1A0", VA = "0x18312D5A0")]
			public void TrySyncDecompressProg()
			{
			}

			// Token: 0x0600982C RID: 38956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600982C")]
			[Address(RVA = "0x312D650", Offset = "0x312C250", VA = "0x18312D650")]
			private void UpdateTaskStatusOnly_MarkTaskEmpty()
			{
			}

			// Token: 0x0600982D RID: 38957 RVA: 0x0003B2B0 File Offset: 0x000394B0
			[Token(Token = "0x600982D")]
			[Address(RVA = "0x312D730", Offset = "0x312C330", VA = "0x18312D730")]
			private bool _CheckIfAllowNewTask()
			{
				return default(bool);
			}

			// Token: 0x0600982E RID: 38958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600982E")]
			[Address(RVA = "0x312D750", Offset = "0x312C350", VA = "0x18312D750")]
			private void _MarkTerminating()
			{
			}

			// Token: 0x04008E0B RID: 36363
			[Token(Token = "0x4008E0B")]
			[FieldOffset(Offset = "0x10")]
			private HGDownloader m_context;

			// Token: 0x04008E0C RID: 36364
			[Token(Token = "0x4008E0C")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isEmpty;

			// Token: 0x04008E0D RID: 36365
			[Token(Token = "0x4008E0D")]
			[FieldOffset(Offset = "0x19")]
			private bool m_isTerminating;

			// Token: 0x04008E0E RID: 36366
			[Token(Token = "0x4008E0E")]
			[FieldOffset(Offset = "0x1A")]
			private bool m_isInited;

			// Token: 0x04008E0F RID: 36367
			[Token(Token = "0x4008E0F")]
			[FieldOffset(Offset = "0x20")]
			private HGDownloader.DownloadTask m_pendingTask;
		}

		// Token: 0x0200178A RID: 6026
		[Token(Token = "0x200178A")]
		private struct DownloadTask
		{
			// Token: 0x0600982F RID: 38959 RVA: 0x0003B2C8 File Offset: 0x000394C8
			[Token(Token = "0x600982F")]
			[Address(RVA = "0x2824A30", Offset = "0x2823630", VA = "0x182824A30")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04008E14 RID: 36372
			[Token(Token = "0x4008E14")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HGDownloader.DownloadTask EMPTY;

			// Token: 0x04008E15 RID: 36373
			[Token(Token = "0x4008E15")]
			[FieldOffset(Offset = "0x0")]
			public string versionId;

			// Token: 0x04008E16 RID: 36374
			[Token(Token = "0x4008E16")]
			[FieldOffset(Offset = "0x8")]
			public IList<HGFileInfo> files;

			// Token: 0x04008E17 RID: 36375
			[Token(Token = "0x4008E17")]
			[FieldOffset(Offset = "0x10")]
			public HGDownloader.TaskHandler handler;

			// Token: 0x04008E18 RID: 36376
			[Token(Token = "0x4008E18")]
			[FieldOffset(Offset = "0x18")]
			public bool useMobileData;

			// Token: 0x04008E19 RID: 36377
			[Token(Token = "0x4008E19")]
			[FieldOffset(Offset = "0x19")]
			public bool needDecompress;
		}
	}
}
