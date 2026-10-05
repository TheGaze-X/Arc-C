using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC9 RID: 27337
	[Token(Token = "0x2006AC9")]
	public class AvgProxy : ActArchiveCompProxy<ArchiveAvgController>
	{
		// Token: 0x17005C6C RID: 23660
		// (get) Token: 0x060271AB RID: 160171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C6C")]
		protected override string compType
		{
			[Token(Token = "0x60271AB")]
			[Address(RVA = "0x225A2A0", Offset = "0x2258EA0", VA = "0x18225A2A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271AC RID: 160172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271AC")]
		[Address(RVA = "0x2259720", Offset = "0x2258320", VA = "0x182259720", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271AD RID: 160173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271AD")]
		[Address(RVA = "0x2259B30", Offset = "0x2258730", VA = "0x182259B30")]
		public void StartAvgAndBackToArchiveAvg(StoryData targetStory, DataBundle stateBundle)
		{
		}

		// Token: 0x060271AE RID: 160174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271AE")]
		[Address(RVA = "0x2259FD0", Offset = "0x2258BD0", VA = "0x182259FD0")]
		private UIPageControllerParam _SceneParamToState(DataBundle bundleToState)
		{
			return null;
		}

		// Token: 0x060271AF RID: 160175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271AF")]
		[Address(RVA = "0x2259EB0", Offset = "0x2258AB0", VA = "0x182259EB0")]
		private void _OnAvgItemClicked(ActArchiveType type, string avgID)
		{
		}

		// Token: 0x060271B0 RID: 160176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271B0")]
		[Address(RVA = "0x225A230", Offset = "0x2258E30", VA = "0x18225A230")]
		public AvgProxy()
		{
		}

		// Token: 0x0403751A RID: 226586
		[Token(Token = "0x403751A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403751B RID: 226587
		[Token(Token = "0x403751B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0403751C RID: 226588
		[Token(Token = "0x403751C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartAvgAndBackToArchiveAvg;

		// Token: 0x0403751D RID: 226589
		[Token(Token = "0x403751D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SceneParamToState;

		// Token: 0x0403751E RID: 226590
		[Token(Token = "0x403751E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnAvgItemClicked;

		// Token: 0x0403751F RID: 226591
		[Token(Token = "0x403751F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
