using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003278 RID: 12920
	[Token(Token = "0x2003278")]
	public class SwitchMapEffectAnimationIfTileHighlightChanged : Effect.Behaviour
	{
		// Token: 0x060147CB RID: 83915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147CB")]
		[Address(RVA = "0xCB6FD0", Offset = "0xCB5BD0", VA = "0x180CB6FD0")]
		public void Awake()
		{
		}

		// Token: 0x060147CC RID: 83916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147CC")]
		[Address(RVA = "0xCB72E0", Offset = "0xCB5EE0", VA = "0x180CB72E0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147CD RID: 83917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147CD")]
		[Address(RVA = "0xCB7480", Offset = "0xCB6080", VA = "0x180CB7480")]
		private void _OnTileHighlightChanged(object item)
		{
		}

		// Token: 0x060147CE RID: 83918 RVA: 0x00086EB0 File Offset: 0x000850B0
		[Token(Token = "0x60147CE")]
		[Address(RVA = "0xCB73E0", Offset = "0xCB5FE0", VA = "0x180CB73E0")]
		private int _GetSpecificHighlightInteger(TileGraphic.HighlightType highlightType)
		{
			return 0;
		}

		// Token: 0x060147CF RID: 83919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147CF")]
		[Address(RVA = "0xCB7160", Offset = "0xCB5D60", VA = "0x180CB7160", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147D0 RID: 83920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D0")]
		[Address(RVA = "0xCB7730", Offset = "0xCB6330", VA = "0x180CB7730")]
		public SwitchMapEffectAnimationIfTileHighlightChanged()
		{
		}

		// Token: 0x060147D1 RID: 83921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D1")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147D2 RID: 83922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D2")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401837A RID: 99194
		[Token(Token = "0x401837A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animatorIntegerKey;

		// Token: 0x0401837B RID: 99195
		[Token(Token = "0x401837B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _highlightNone;

		// Token: 0x0401837C RID: 99196
		[Token(Token = "0x401837C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _highlightBuildable;

		// Token: 0x0401837D RID: 99197
		[Token(Token = "0x401837D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _highlightFocus;

		// Token: 0x0401837E RID: 99198
		[Token(Token = "0x401837E")]
		[FieldOffset(Offset = "0x38")]
		private MapEffect m_mapEffect;

		// Token: 0x0401837F RID: 99199
		[Token(Token = "0x401837F")]
		[FieldOffset(Offset = "0x40")]
		private Animator m_animator;

		// Token: 0x04018380 RID: 99200
		[Token(Token = "0x4018380")]
		private const int INVALID_VALUE = -1;

		// Token: 0x04018381 RID: 99201
		[Token(Token = "0x4018381")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018382 RID: 99202
		[Token(Token = "0x4018382")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018383 RID: 99203
		[Token(Token = "0x4018383")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTileHighlightChanged;

		// Token: 0x04018384 RID: 99204
		[Token(Token = "0x4018384")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetSpecificHighlightInteger;

		// Token: 0x04018385 RID: 99205
		[Token(Token = "0x4018385")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018386 RID: 99206
		[Token(Token = "0x4018386")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
