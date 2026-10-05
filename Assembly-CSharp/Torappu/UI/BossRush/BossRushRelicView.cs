using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006192 RID: 24978
	[Token(Token = "0x2006192")]
	public class BossRushRelicView : DataBinder<BossRushRelicViewProperty>
	{
		// Token: 0x1700550A RID: 21770
		// (get) Token: 0x0602407C RID: 147580 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602407D RID: 147581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700550A")]
		public Action<BossRushRelicNodeModel> onSelectRelicAction
		{
			[Token(Token = "0x602407C")]
			[Address(RVA = "0x1EAB070", Offset = "0x1EA9C70", VA = "0x181EAB070")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602407D")]
			[Address(RVA = "0x1EAB130", Offset = "0x1EA9D30", VA = "0x181EAB130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700550B RID: 21771
		// (get) Token: 0x0602407E RID: 147582 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602407F RID: 147583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700550B")]
		public Action<BossRushRelicNodeModel> onUpgradeClickedAction
		{
			[Token(Token = "0x602407E")]
			[Address(RVA = "0x1EAB0D0", Offset = "0x1EA9CD0", VA = "0x181EAB0D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602407F")]
			[Address(RVA = "0x1EAB1B0", Offset = "0x1EA9DB0", VA = "0x181EAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024080 RID: 147584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024080")]
		[Address(RVA = "0x1EAAB40", Offset = "0x1EA9740", VA = "0x181EAAB40", Slot = "7")]
		public override void OnValueChanged(BossRushRelicViewProperty property)
		{
		}

		// Token: 0x06024081 RID: 147585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024081")]
		[Address(RVA = "0x1EAAE70", Offset = "0x1EA9A70", VA = "0x181EAAE70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024082 RID: 147586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024082")]
		[Address(RVA = "0x1EAB000", Offset = "0x1EA9C00", VA = "0x181EAB000")]
		public BossRushRelicView()
		{
		}

		// Token: 0x040320F4 RID: 205044
		[Token(Token = "0x40320F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _contentRelicList;

		// Token: 0x040320F5 RID: 205045
		[Token(Token = "0x40320F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _tokenPart;

		// Token: 0x040320F6 RID: 205046
		[Token(Token = "0x40320F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completedPart;

		// Token: 0x040320F7 RID: 205047
		[Token(Token = "0x40320F7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _emptyInfoCanvas;

		// Token: 0x040320F8 RID: 205048
		[Token(Token = "0x40320F8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtTokenName;

		// Token: 0x040320F9 RID: 205049
		[Token(Token = "0x40320F9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtTokenCount;

		// Token: 0x040320FC RID: 205052
		[Token(Token = "0x40320FC")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x040320FD RID: 205053
		[Token(Token = "0x40320FD")]
		[FieldOffset(Offset = "0x68")]
		private BossRushRelicView.Adapter m_adapter;

		// Token: 0x040320FE RID: 205054
		[Token(Token = "0x40320FE")]
		[FieldOffset(Offset = "0x70")]
		private BossRushRelicViewModel m_viewModel;

		// Token: 0x040320FF RID: 205055
		[Token(Token = "0x40320FF")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_doTween;

		// Token: 0x04032100 RID: 205056
		[Token(Token = "0x4032100")]
		private const float ALPHA_DURATION = 0.4f;

		// Token: 0x04032101 RID: 205057
		[Token(Token = "0x4032101")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSelectRelicAction;

		// Token: 0x04032102 RID: 205058
		[Token(Token = "0x4032102")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSelectRelicAction;

		// Token: 0x04032103 RID: 205059
		[Token(Token = "0x4032103")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onUpgradeClickedAction;

		// Token: 0x04032104 RID: 205060
		[Token(Token = "0x4032104")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onUpgradeClickedAction;

		// Token: 0x04032105 RID: 205061
		[Token(Token = "0x4032105")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032106 RID: 205062
		[Token(Token = "0x4032106")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032107 RID: 205063
		[Token(Token = "0x4032107")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006193 RID: 24979
		[Token(Token = "0x2006193")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06024083 RID: 147587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024083")]
			[Address(RVA = "0x1E9DC90", Offset = "0x1E9C890", VA = "0x181E9DC90")]
			public Adapter(BossRushRelicView closure)
			{
			}

			// Token: 0x1700550C RID: 21772
			// (get) Token: 0x06024084 RID: 147588 RVA: 0x000C2CD0 File Offset: 0x000C0ED0
			[Token(Token = "0x1700550C")]
			public override int count
			{
				[Token(Token = "0x6024084")]
				[Address(RVA = "0x1E9DF50", Offset = "0x1E9CB50", VA = "0x181E9DF50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024085 RID: 147589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024085")]
			[Address(RVA = "0x1E9D980", Offset = "0x1E9C580", VA = "0x181E9D980", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04032108 RID: 205064
			[Token(Token = "0x4032108")]
			[FieldOffset(Offset = "0x20")]
			private BossRushRelicView m_closure;

			// Token: 0x04032109 RID: 205065
			[Token(Token = "0x4032109")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403210A RID: 205066
			[Token(Token = "0x403210A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403210B RID: 205067
			[Token(Token = "0x403210B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
