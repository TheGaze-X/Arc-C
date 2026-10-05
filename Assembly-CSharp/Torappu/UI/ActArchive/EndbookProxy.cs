using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ACD RID: 27341
	[Token(Token = "0x2006ACD")]
	public class EndbookProxy : ActArchiveCompProxy<ArchiveEndbookController>
	{
		// Token: 0x17005C70 RID: 23664
		// (get) Token: 0x060271BE RID: 160190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C70")]
		protected override string compType
		{
			[Token(Token = "0x60271BE")]
			[Address(RVA = "0x225D200", Offset = "0x225BE00", VA = "0x18225D200", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271BF RID: 160191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271BF")]
		[Address(RVA = "0x225C3B0", Offset = "0x225AFB0", VA = "0x18225C3B0", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271C0 RID: 160192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271C0")]
		[Address(RVA = "0x225C480", Offset = "0x225B080", VA = "0x18225C480", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271C1 RID: 160193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271C1")]
		[Address(RVA = "0x225CBD0", Offset = "0x225B7D0", VA = "0x18225CBD0")]
		private void _OnEndClicked(ActArchiveType type, string endId)
		{
		}

		// Token: 0x060271C2 RID: 160194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271C2")]
		[Address(RVA = "0x225CE10", Offset = "0x225BA10", VA = "0x18225CE10")]
		private void _OnIndexConfirm(ActArchiveType type, int index)
		{
		}

		// Token: 0x060271C3 RID: 160195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271C3")]
		[Address(RVA = "0x225CCF0", Offset = "0x225B8F0", VA = "0x18225CCF0")]
		private void _OnEndItemClicked(ActArchiveType type, int index)
		{
		}

		// Token: 0x060271C4 RID: 160196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271C4")]
		[Address(RVA = "0x225C850", Offset = "0x225B450", VA = "0x18225C850")]
		public void StartAvgAndBackToArchiveEndbook(StoryData targetStory, DataBundle stateBundle)
		{
		}

		// Token: 0x060271C5 RID: 160197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271C5")]
		[Address(RVA = "0x225CF30", Offset = "0x225BB30", VA = "0x18225CF30")]
		private UIPageControllerParam _SceneParamToState(DataBundle bundleToState)
		{
			return null;
		}

		// Token: 0x060271C6 RID: 160198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271C6")]
		[Address(RVA = "0x225D190", Offset = "0x225BD90", VA = "0x18225D190")]
		public EndbookProxy()
		{
		}

		// Token: 0x0403752D RID: 226605
		[Token(Token = "0x403752D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403752E RID: 226606
		[Token(Token = "0x403752E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x0403752F RID: 226607
		[Token(Token = "0x403752F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037530 RID: 226608
		[Token(Token = "0x4037530")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnEndClicked;

		// Token: 0x04037531 RID: 226609
		[Token(Token = "0x4037531")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnIndexConfirm;

		// Token: 0x04037532 RID: 226610
		[Token(Token = "0x4037532")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnEndItemClicked;

		// Token: 0x04037533 RID: 226611
		[Token(Token = "0x4037533")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StartAvgAndBackToArchiveEndbook;

		// Token: 0x04037534 RID: 226612
		[Token(Token = "0x4037534")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SceneParamToState;

		// Token: 0x04037535 RID: 226613
		[Token(Token = "0x4037535")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
