using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073E4 RID: 29668
	[Token(Token = "0x20073E4")]
	public class UIGachaBoxDrawEffectFloatPage : UIOneshotEffectFloatPanel, IHotfixable
	{
		// Token: 0x06029E7E RID: 171646 RVA: 0x000D6F38 File Offset: 0x000D5138
		[Token(Token = "0x6029E7E")]
		[Address(RVA = "0x2595310", Offset = "0x2593F10", VA = "0x182595310")]
		public bool ShowIfNot(UIGachaBoxDrawEffectFloatPage.Options options)
		{
			return default(bool);
		}

		// Token: 0x06029E7F RID: 171647 RVA: 0x000D6F50 File Offset: 0x000D5150
		[Token(Token = "0x6029E7F")]
		[Address(RVA = "0x2594F80", Offset = "0x2593B80", VA = "0x182594F80", Slot = "5")]
		public override bool FinishIfNot()
		{
			return default(bool);
		}

		// Token: 0x06029E80 RID: 171648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E80")]
		[Address(RVA = "0x2595010", Offset = "0x2593C10", VA = "0x182595010")]
		public void OnClicked()
		{
		}

		// Token: 0x06029E81 RID: 171649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E81")]
		[Address(RVA = "0x2595500", Offset = "0x2594100", VA = "0x182595500")]
		private TrackEntry _StartSpineAnimation()
		{
			return null;
		}

		// Token: 0x06029E82 RID: 171650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E82")]
		[Address(RVA = "0x25953C0", Offset = "0x2593FC0", VA = "0x1825953C0")]
		private string _GetSkinNameFromStyle(UIGachaBoxDrawEffectFloatPage.Style style)
		{
			return null;
		}

		// Token: 0x06029E83 RID: 171651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E83")]
		[Address(RVA = "0x2595460", Offset = "0x2594060", VA = "0x182595460")]
		private void _SetActiveOfSpineAndEffect(bool isActive)
		{
		}

		// Token: 0x06029E84 RID: 171652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E84")]
		[Address(RVA = "0x2595260", Offset = "0x2593E60", VA = "0x182595260", Slot = "9")]
		protected override IEnumerator PlayEffect()
		{
			return null;
		}

		// Token: 0x06029E85 RID: 171653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E85")]
		[Address(RVA = "0x2595160", Offset = "0x2593D60", VA = "0x182595160", Slot = "6")]
		protected override void OnReset()
		{
		}

		// Token: 0x06029E86 RID: 171654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E86")]
		[Address(RVA = "0x25951C0", Offset = "0x2593DC0", VA = "0x1825951C0", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x06029E87 RID: 171655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E87")]
		[Address(RVA = "0x2595090", Offset = "0x2593C90", VA = "0x182595090", Slot = "8")]
		protected override void OnFinish()
		{
		}

		// Token: 0x06029E88 RID: 171656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E88")]
		[Address(RVA = "0x25956C0", Offset = "0x25942C0", VA = "0x1825956C0")]
		public UIGachaBoxDrawEffectFloatPage()
		{
		}

		// Token: 0x06029E89 RID: 171657 RVA: 0x000D6F68 File Offset: 0x000D5168
		[Token(Token = "0x6029E89")]
		[Address(RVA = "0x25953B0", Offset = "0x2593FB0", VA = "0x1825953B0")]
		private bool <>xLuaBaseProxy_FinishIfNot()
		{
			return default(bool);
		}

		// Token: 0x06029E8A RID: 171658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E8A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x06029E8B RID: 171659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E8B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06029E8C RID: 171660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E8C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0403C0E5 RID: 245989
		[Token(Token = "0x403C0E5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isSkippable;

		// Token: 0x0403C0E6 RID: 245990
		[Token(Token = "0x403C0E6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x0403C0E7 RID: 245991
		[Token(Token = "0x403C0E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SkeletonGraphic _spineGraphic;

		// Token: 0x0403C0E8 RID: 245992
		[Token(Token = "0x403C0E8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _effectHolder;

		// Token: 0x0403C0E9 RID: 245993
		[Token(Token = "0x403C0E9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Collection(typeof(UIGachaBoxDrawEffectFloatPage.Style))]
		private string[] _skinNameOfStyles;

		// Token: 0x0403C0EA RID: 245994
		[Token(Token = "0x403C0EA")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isBlurShown;

		// Token: 0x0403C0EB RID: 245995
		[Token(Token = "0x403C0EB")]
		[FieldOffset(Offset = "0x58")]
		private UIGachaBoxDrawEffectFloatPage.Options m_options;

		// Token: 0x0403C0EC RID: 245996
		[Token(Token = "0x403C0EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowIfNot;

		// Token: 0x0403C0ED RID: 245997
		[Token(Token = "0x403C0ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FinishIfNot;

		// Token: 0x0403C0EE RID: 245998
		[Token(Token = "0x403C0EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403C0EF RID: 245999
		[Token(Token = "0x403C0EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__StartSpineAnimation;

		// Token: 0x0403C0F0 RID: 246000
		[Token(Token = "0x403C0F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetSkinNameFromStyle;

		// Token: 0x0403C0F1 RID: 246001
		[Token(Token = "0x403C0F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetActiveOfSpineAndEffect;

		// Token: 0x0403C0F2 RID: 246002
		[Token(Token = "0x403C0F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayEffect;

		// Token: 0x0403C0F3 RID: 246003
		[Token(Token = "0x403C0F3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0403C0F4 RID: 246004
		[Token(Token = "0x403C0F4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403C0F5 RID: 246005
		[Token(Token = "0x403C0F5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0403C0F6 RID: 246006
		[Token(Token = "0x403C0F6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073E5 RID: 29669
		[Token(Token = "0x20073E5")]
		[Serializable]
		public enum Style
		{
			// Token: 0x0403C0F8 RID: 246008
			[Token(Token = "0x403C0F8")]
			WHITE,
			// Token: 0x0403C0F9 RID: 246009
			[Token(Token = "0x403C0F9")]
			YELLOW,
			// Token: 0x0403C0FA RID: 246010
			[Token(Token = "0x403C0FA")]
			RED,
			// Token: 0x0403C0FB RID: 246011
			[Token(Token = "0x403C0FB")]
			GREEN
		}

		// Token: 0x020073E6 RID: 29670
		[Token(Token = "0x20073E6")]
		public struct Options
		{
			// Token: 0x0403C0FC RID: 246012
			[Token(Token = "0x403C0FC")]
			[FieldOffset(Offset = "0x0")]
			public UIGachaBoxDrawEffectFloatPage.Style style;

			// Token: 0x0403C0FD RID: 246013
			[Token(Token = "0x403C0FD")]
			[FieldOffset(Offset = "0x8")]
			public Action onFinish;
		}
	}
}
