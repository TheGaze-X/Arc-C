using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F71 RID: 16241
	[Token(Token = "0x2003F71")]
	public class SiracusaMapChatStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x06019341 RID: 103233 RVA: 0x0009D398 File Offset: 0x0009B598
		[Token(Token = "0x17003C32")]
		public bool isReplay
		{
			[Token(Token = "0x6019341")]
			[Address(RVA = "0x11EA760", Offset = "0x11E9360", VA = "0x1811EA760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06019342 RID: 103234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019342")]
		[Address(RVA = "0x11E9F50", Offset = "0x11E8B50", VA = "0x1811E9F50")]
		public void LoadData(SiracusaMapController.SiracusaMapChatParam param)
		{
		}

		// Token: 0x06019343 RID: 103235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019343")]
		[Address(RVA = "0x11EA2B0", Offset = "0x11E8EB0", VA = "0x1811EA2B0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06019344 RID: 103236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019344")]
		[Address(RVA = "0x11EA670", Offset = "0x11E9270", VA = "0x1811EA670")]
		public SiracusaMapChatStateBean()
		{
		}

		// Token: 0x0401F3F6 RID: 127990
		[Token(Token = "0x401F3F6")]
		[FieldOffset(Offset = "0x10")]
		public string charCardId;

		// Token: 0x0401F3F7 RID: 127991
		[Token(Token = "0x401F3F7")]
		[FieldOffset(Offset = "0x18")]
		public string taskRingId;

		// Token: 0x0401F3F8 RID: 127992
		[Token(Token = "0x401F3F8")]
		[FieldOffset(Offset = "0x20")]
		public string taskInfoId;

		// Token: 0x0401F3F9 RID: 127993
		[Token(Token = "0x401F3F9")]
		[FieldOffset(Offset = "0x28")]
		public string groupId;

		// Token: 0x0401F3FA RID: 127994
		[Token(Token = "0x401F3FA")]
		[FieldOffset(Offset = "0x30")]
		public string pointName;

		// Token: 0x0401F3FB RID: 127995
		[Token(Token = "0x401F3FB")]
		[FieldOffset(Offset = "0x38")]
		public string pointDesc;

		// Token: 0x0401F3FC RID: 127996
		[Token(Token = "0x401F3FC")]
		[FieldOffset(Offset = "0x40")]
		public string lastSelectOptionId;

		// Token: 0x0401F3FD RID: 127997
		[Token(Token = "0x401F3FD")]
		[FieldOffset(Offset = "0x48")]
		public bool isChatComplete;

		// Token: 0x0401F3FE RID: 127998
		[Token(Token = "0x401F3FE")]
		[FieldOffset(Offset = "0x50")]
		public SiracusaMapChatProperty chatProperty;

		// Token: 0x0401F3FF RID: 127999
		[Token(Token = "0x401F3FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isReplay;

		// Token: 0x0401F400 RID: 128000
		[Token(Token = "0x401F400")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401F401 RID: 128001
		[Token(Token = "0x401F401")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0401F402 RID: 128002
		[Token(Token = "0x401F402")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
