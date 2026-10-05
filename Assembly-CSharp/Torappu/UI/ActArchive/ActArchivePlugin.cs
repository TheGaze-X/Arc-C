using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AB0 RID: 27312
	[Token(Token = "0x2006AB0")]
	public abstract class ActArchivePlugin : IHotfixable
	{
		// Token: 0x0602712D RID: 160045
		[Token(Token = "0x602712D")]
		public abstract ActArchiveType GetArchiveEntryType();

		// Token: 0x0602712E RID: 160046
		[Token(Token = "0x602712E")]
		public abstract bool GetArchiveItemValidStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType);

		// Token: 0x0602712F RID: 160047
		[Token(Token = "0x602712F")]
		public abstract bool GetArchiveItemLockStatus(string archiveId, string archiveItemId, ActArchiveType archiveItemType, out string lockedToast);

		// Token: 0x06027130 RID: 160048
		[Token(Token = "0x6027130")]
		public abstract List<UIPageStackParam.StackElement> GetSceneParamToState(string archiveId);

		// Token: 0x06027131 RID: 160049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027131")]
		[Address(RVA = "0x2234A00", Offset = "0x2233600", VA = "0x182234A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027132 RID: 160050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027132")]
		[Address(RVA = "0x2234950", Offset = "0x2233550", VA = "0x182234950")]
		protected void RegisterCompPlugin(ActArchiveType archiveType, ActArchivePlugin.IActArchiveCompPlugin archiveCompPlugin)
		{
		}

		// Token: 0x06027133 RID: 160051 RVA: 0x000CD6C8 File Offset: 0x000CB8C8
		[Token(Token = "0x6027133")]
		[Address(RVA = "0x2234880", Offset = "0x2233480", VA = "0x182234880")]
		public bool HasCompPlugin(ActArchiveType archiveType)
		{
			return default(bool);
		}

		// Token: 0x06027134 RID: 160052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027134")]
		[Address(RVA = "0x22347F0", Offset = "0x22333F0", VA = "0x1822347F0")]
		public ActArchivePlugin.IActArchiveCompPlugin GetCompPlugin(ActArchiveType archiveType)
		{
			return null;
		}

		// Token: 0x06027135 RID: 160053
		[Token(Token = "0x6027135")]
		public abstract void ConstructCompPlugin();

		// Token: 0x06027136 RID: 160054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027136")]
		[Address(RVA = "0x2234A90", Offset = "0x2233690", VA = "0x182234A90")]
		protected ActArchivePlugin()
		{
		}

		// Token: 0x040374AB RID: 226475
		[Token(Token = "0x40374AB")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasInited;

		// Token: 0x040374AC RID: 226476
		[Token(Token = "0x40374AC")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ActArchiveType, ActArchivePlugin.IActArchiveCompPlugin> m_compPlugin;

		// Token: 0x040374AD RID: 226477
		[Token(Token = "0x40374AD")]
		[FieldOffset(Offset = "0x20")]
		public DataBundle passthroughData;

		// Token: 0x040374AE RID: 226478
		[Token(Token = "0x40374AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040374AF RID: 226479
		[Token(Token = "0x40374AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterCompPlugin;

		// Token: 0x040374B0 RID: 226480
		[Token(Token = "0x40374B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HasCompPlugin;

		// Token: 0x040374B1 RID: 226481
		[Token(Token = "0x40374B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCompPlugin;

		// Token: 0x040374B2 RID: 226482
		[Token(Token = "0x40374B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006AB1 RID: 27313
		[Token(Token = "0x2006AB1")]
		public interface IActArchiveCompPlugin : IHotfixable
		{
		}

		// Token: 0x02006AB2 RID: 27314
		[Token(Token = "0x2006AB2")]
		public interface IActArchiveMusicPlugin : ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06027137 RID: 160055
			[Token(Token = "0x6027137")]
			bool SetHomeTheme(string archiveId, string gameMusicId, long bgmInstId);

			// Token: 0x06027138 RID: 160056
			[Token(Token = "0x6027138")]
			string GetHomeTheme(string archiveId);
		}

		// Token: 0x02006AB3 RID: 27315
		[Token(Token = "0x2006AB3")]
		public interface IActArchivePicPlugin : ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06027139 RID: 160057
			[Token(Token = "0x6027139")]
			bool SetHomeKV(string archiveId, string kvId);

			// Token: 0x0602713A RID: 160058
			[Token(Token = "0x602713A")]
			string GetHomeKV(string archiveId);
		}

		// Token: 0x02006AB4 RID: 27316
		[Token(Token = "0x2006AB4")]
		public interface IActArchiveNewsPlugin : ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0602713B RID: 160059
			[Token(Token = "0x602713B")]
			int GetNewsParamT(string archiveId);
		}

		// Token: 0x02006AB5 RID: 27317
		[Token(Token = "0x2006AB5")]
		public interface IActArchiveChallengeBookPlugin : ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0602713C RID: 160060
			[Token(Token = "0x602713C")]
			bool NeedClosePageOnBack(string archiveId);

			// Token: 0x0602713D RID: 160061
			[Token(Token = "0x602713D")]
			string GetArchiveTrackType(string archiveId);
		}

		// Token: 0x02006AB6 RID: 27318
		[Token(Token = "0x2006AB6")]
		public interface IActArchiveButtonViewPlugin : IHotfixable
		{
			// Token: 0x0602713E RID: 160062
			[Token(Token = "0x602713E")]
			void ApplyData(ActArchiveCompInfo data);
		}

		// Token: 0x02006AB7 RID: 27319
		[Token(Token = "0x2006AB7")]
		public interface IActArchiveAchievementPlugin : ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x0602713F RID: 160063
			[Token(Token = "0x602713F")]
			Dictionary<string, ArchiveAchievementListFilterViewModel> GetFilters(string archiveId);
		}

		// Token: 0x02006AB8 RID: 27320
		[Token(Token = "0x2006AB8")]
		public interface IActArchiveEntryPlugin : ActArchivePlugin.IActArchiveCompPlugin, IHotfixable
		{
			// Token: 0x06027140 RID: 160064
			[Token(Token = "0x6027140")]
			string GetEntryMusicId(string archiveId);
		}
	}
}
