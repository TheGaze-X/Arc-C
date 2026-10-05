using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007916 RID: 30998
	[Token(Token = "0x2007916")]
	public class Act1ArcadeStateViewStatusComp : PageSingleComponent
	{
		// Token: 0x0602B7D1 RID: 178129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D1")]
		[Address(RVA = "0x2778600", Offset = "0x2777200", VA = "0x182778600")]
		public void ChangeToState(Type stateType)
		{
		}

		// Token: 0x0602B7D2 RID: 178130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D2")]
		[Address(RVA = "0x27787A0", Offset = "0x27773A0", VA = "0x1827787A0")]
		public void OnStatePreResume(Type stateType, bool isFromStack)
		{
		}

		// Token: 0x0602B7D3 RID: 178131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D3")]
		[Address(RVA = "0x2778910", Offset = "0x2777510", VA = "0x182778910")]
		public void OnStateResume(Type stateType, bool isFromStack)
		{
		}

		// Token: 0x0602B7D4 RID: 178132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7D4")]
		public Act1ArcadeStateStatusBaseView RegisterView<T>(string actId, string prefabId, ILoadAsset assetLoader) where T : State
		{
			return null;
		}

		// Token: 0x0602B7D5 RID: 178133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D5")]
		[Address(RVA = "0x27786C0", Offset = "0x27772C0", VA = "0x1827786C0")]
		private void HideAllView()
		{
		}

		// Token: 0x0602B7D6 RID: 178134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D6")]
		[Address(RVA = "0x2778A80", Offset = "0x2777680", VA = "0x182778A80")]
		private void _SetAsCurView(Type stateType)
		{
		}

		// Token: 0x0602B7D7 RID: 178135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D7")]
		[Address(RVA = "0x2778BD0", Offset = "0x27777D0", VA = "0x182778BD0")]
		public Act1ArcadeStateViewStatusComp()
		{
		}

		// Token: 0x0403EE09 RID: 257545
		[Token(Token = "0x403EE09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _viewRoot;

		// Token: 0x0403EE0A RID: 257546
		[Token(Token = "0x403EE0A")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Type, Act1ArcadeStateStatusBaseView> m_viewDict;

		// Token: 0x0403EE0B RID: 257547
		[Token(Token = "0x403EE0B")]
		[FieldOffset(Offset = "0x30")]
		private Act1ArcadeStateStatusBaseView m_curView;

		// Token: 0x0403EE0C RID: 257548
		[Token(Token = "0x403EE0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ChangeToState;

		// Token: 0x0403EE0D RID: 257549
		[Token(Token = "0x403EE0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStatePreResume;

		// Token: 0x0403EE0E RID: 257550
		[Token(Token = "0x403EE0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateResume;

		// Token: 0x0403EE0F RID: 257551
		[Token(Token = "0x403EE0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterView;

		// Token: 0x0403EE10 RID: 257552
		[Token(Token = "0x403EE10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideAllView;

		// Token: 0x0403EE11 RID: 257553
		[Token(Token = "0x403EE11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetAsCurView;

		// Token: 0x0403EE12 RID: 257554
		[Token(Token = "0x403EE12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
