using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004969 RID: 18793
	[Token(Token = "0x2004969")]
	public class MedalDetailMiddleHolderSingleton : PageSingleComponent, IHotfixable
	{
		// Token: 0x0601C52D RID: 116013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C52D")]
		[Address(RVA = "0x15CA160", Offset = "0x15C8D60", VA = "0x1815CA160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C52E RID: 116014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C52E")]
		[Address(RVA = "0x15C9750", Offset = "0x15C8350", VA = "0x1815C9750")]
		public static void OnOpenDetailStatic(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C52F RID: 116015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C52F")]
		[Address(RVA = "0x15C9830", Offset = "0x15C8430", VA = "0x1815C9830")]
		public void OnOpenDetail(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C530 RID: 116016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C530")]
		[Address(RVA = "0x15C9350", Offset = "0x15C7F50", VA = "0x1815C9350")]
		public static void CloseStatic()
		{
		}

		// Token: 0x0601C531 RID: 116017 RVA: 0x000A7DA8 File Offset: 0x000A5FA8
		[Token(Token = "0x601C531")]
		[Address(RVA = "0x15C9680", Offset = "0x15C8280", VA = "0x1815C9680")]
		public static bool IsShow()
		{
			return default(bool);
		}

		// Token: 0x0601C532 RID: 116018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C532")]
		[Address(RVA = "0x15C9430", Offset = "0x15C8030", VA = "0x1815C9430")]
		public void Close()
		{
		}

		// Token: 0x0601C533 RID: 116019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C533")]
		[Address(RVA = "0x15C9DD0", Offset = "0x15C89D0", VA = "0x1815C9DD0")]
		public void OpenAlready(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C534 RID: 116020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C534")]
		[Address(RVA = "0x15C9F20", Offset = "0x15C8B20", VA = "0x1815C9F20")]
		public void OpenNotGet(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C535 RID: 116021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C535")]
		[Address(RVA = "0x15CA260", Offset = "0x15C8E60", VA = "0x1815CA260")]
		public MedalDetailMiddleHolderSingleton()
		{
		}

		// Token: 0x040250CF RID: 151759
		[Token(Token = "0x40250CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MedalListAlreadyGetItemDetailView _detailView;

		// Token: 0x040250D0 RID: 151760
		[Token(Token = "0x40250D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalListNoGetItemDetailView _noGetDetailView;

		// Token: 0x040250D1 RID: 151761
		[Token(Token = "0x40250D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040250D2 RID: 151762
		[Token(Token = "0x40250D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _activeHolder;

		// Token: 0x040250D3 RID: 151763
		[Token(Token = "0x40250D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRenderTextureImage _blurImage;

		// Token: 0x040250D4 RID: 151764
		[Token(Token = "0x40250D4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040250D5 RID: 151765
		[Token(Token = "0x40250D5")]
		[FieldOffset(Offset = "0x50")]
		private Action m_dismissAct;

		// Token: 0x040250D6 RID: 151766
		[Token(Token = "0x40250D6")]
		[FieldOffset(Offset = "0x58")]
		private MedalListAlreadyGetItemDetailView m_detailView;

		// Token: 0x040250D7 RID: 151767
		[Token(Token = "0x40250D7")]
		[FieldOffset(Offset = "0x60")]
		private MedalListNoGetItemDetailView m_noGetDetailView;

		// Token: 0x040250D8 RID: 151768
		[Token(Token = "0x40250D8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x040250D9 RID: 151769
		[Token(Token = "0x40250D9")]
		[FieldOffset(Offset = "0x69")]
		private bool m_isShow;

		// Token: 0x040250DA RID: 151770
		[Token(Token = "0x40250DA")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_cacheTween;

		// Token: 0x040250DB RID: 151771
		[Token(Token = "0x40250DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040250DC RID: 151772
		[Token(Token = "0x40250DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnOpenDetailStatic;

		// Token: 0x040250DD RID: 151773
		[Token(Token = "0x40250DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenDetail;

		// Token: 0x040250DE RID: 151774
		[Token(Token = "0x40250DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CloseStatic;

		// Token: 0x040250DF RID: 151775
		[Token(Token = "0x40250DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsShow;

		// Token: 0x040250E0 RID: 151776
		[Token(Token = "0x40250E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x040250E1 RID: 151777
		[Token(Token = "0x40250E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenAlready;

		// Token: 0x040250E2 RID: 151778
		[Token(Token = "0x40250E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenNotGet;

		// Token: 0x040250E3 RID: 151779
		[Token(Token = "0x40250E3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
