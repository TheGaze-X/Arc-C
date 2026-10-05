using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004967 RID: 18791
	[Token(Token = "0x2004967")]
	public class MedalCommonItemView : MonoBehaviour, IHotfixable, IAsyncDataView<MedalCommonItemView.AsyncParam>, IAsyncShowEffect
	{
		// Token: 0x0601C528 RID: 116008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C528")]
		[Address(RVA = "0x15C7DA0", Offset = "0x15C69A0", VA = "0x1815C7DA0", Slot = "4")]
		public void AsyncSetData(MedalCommonItemView.AsyncParam param)
		{
		}

		// Token: 0x0601C529 RID: 116009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C529")]
		[Address(RVA = "0x15C7E60", Offset = "0x15C6A60", VA = "0x1815C7E60", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601C52A RID: 116010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C52A")]
		[Address(RVA = "0x15C7FC0", Offset = "0x15C6BC0", VA = "0x1815C7FC0")]
		public void Render(MedalCommonViewModel viewModel, bool ableToGetFlag, string pageName)
		{
		}

		// Token: 0x0601C52B RID: 116011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C52B")]
		[Address(RVA = "0x15C7F30", Offset = "0x15C6B30", VA = "0x1815C7F30")]
		public void OnClick()
		{
		}

		// Token: 0x0601C52C RID: 116012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C52C")]
		[Address(RVA = "0x15C8180", Offset = "0x15C6D80", VA = "0x1815C8180")]
		public MedalCommonItemView()
		{
		}

		// Token: 0x040250C0 RID: 151744
		[Token(Token = "0x40250C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MedalCommonItemAbleToGetView _ableToGetView;

		// Token: 0x040250C1 RID: 151745
		[Token(Token = "0x40250C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MedalCommonItemAlreadyGetView _alreadyGetView;

		// Token: 0x040250C2 RID: 151746
		[Token(Token = "0x40250C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalCommonItemNotGetView _notGetView;

		// Token: 0x040250C3 RID: 151747
		[Token(Token = "0x40250C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x040250C4 RID: 151748
		[Token(Token = "0x40250C4")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public UIMedalEvent clickEvent;

		// Token: 0x040250C5 RID: 151749
		[Token(Token = "0x40250C5")]
		[FieldOffset(Offset = "0x40")]
		private MedalCommonViewModel m_viewModel;

		// Token: 0x040250C6 RID: 151750
		[Token(Token = "0x40250C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x040250C7 RID: 151751
		[Token(Token = "0x40250C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x040250C8 RID: 151752
		[Token(Token = "0x40250C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040250C9 RID: 151753
		[Token(Token = "0x40250C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040250CA RID: 151754
		[Token(Token = "0x40250CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004968 RID: 18792
		[Token(Token = "0x2004968")]
		public struct AsyncParam
		{
			// Token: 0x040250CB RID: 151755
			[Token(Token = "0x40250CB")]
			[FieldOffset(Offset = "0x0")]
			public MedalCommonViewModel viewModel;

			// Token: 0x040250CC RID: 151756
			[Token(Token = "0x40250CC")]
			[FieldOffset(Offset = "0x8")]
			public bool ableToGetFlag;

			// Token: 0x040250CD RID: 151757
			[Token(Token = "0x40250CD")]
			[FieldOffset(Offset = "0x10")]
			public string pageName;

			// Token: 0x040250CE RID: 151758
			[Token(Token = "0x40250CE")]
			[FieldOffset(Offset = "0x18")]
			public UIMedalEvent clickEvent;
		}
	}
}
