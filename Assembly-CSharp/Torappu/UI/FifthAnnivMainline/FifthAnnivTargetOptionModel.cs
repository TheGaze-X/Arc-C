using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EA4 RID: 20132
	[Token(Token = "0x2004EA4")]
	public class FifthAnnivTargetOptionModel : FifthAnnivExploreOptionModel
	{
		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x0601E095 RID: 123029 RVA: 0x000AD3B8 File Offset: 0x000AB5B8
		// (set) Token: 0x0601E096 RID: 123030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700467B")]
		public int targetIdx
		{
			[Token(Token = "0x601E095")]
			[Address(RVA = "0x17C4B50", Offset = "0x17C3750", VA = "0x1817C4B50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601E096")]
			[Address(RVA = "0x17C4C20", Offset = "0x17C3820", VA = "0x1817C4C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x0601E097 RID: 123031 RVA: 0x000AD3D0 File Offset: 0x000AB5D0
		// (set) Token: 0x0601E098 RID: 123032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700467C")]
		public bool isOptionEnable
		{
			[Token(Token = "0x601E097")]
			[Address(RVA = "0x17C4AF0", Offset = "0x17C36F0", VA = "0x1817C4AF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E098")]
			[Address(RVA = "0x17C4BB0", Offset = "0x17C37B0", VA = "0x1817C4BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E099 RID: 123033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E099")]
		[Address(RVA = "0x17C45C0", Offset = "0x17C31C0", VA = "0x1817C45C0")]
		public void LoadData(int index, string targetId)
		{
		}

		// Token: 0x0601E09A RID: 123034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E09A")]
		[Address(RVA = "0x17C4A50", Offset = "0x17C3650", VA = "0x1817C4A50")]
		public FifthAnnivTargetOptionModel()
		{
		}

		// Token: 0x04027F0C RID: 163596
		[Token(Token = "0x4027F0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetIdx;

		// Token: 0x04027F0D RID: 163597
		[Token(Token = "0x4027F0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_targetIdx;

		// Token: 0x04027F0E RID: 163598
		[Token(Token = "0x4027F0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isOptionEnable;

		// Token: 0x04027F0F RID: 163599
		[Token(Token = "0x4027F0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isOptionEnable;

		// Token: 0x04027F10 RID: 163600
		[Token(Token = "0x4027F10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027F11 RID: 163601
		[Token(Token = "0x4027F11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
