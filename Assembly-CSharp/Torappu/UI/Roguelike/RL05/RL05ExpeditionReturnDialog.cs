using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055BD RID: 21949
	[Token(Token = "0x20055BD")]
	public class RL05ExpeditionReturnDialog : UIRoguelikeExpeditionReturnDialogBase
	{
		// Token: 0x06020386 RID: 131974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020386")]
		[Address(RVA = "0x1A511F0", Offset = "0x1A4FDF0", VA = "0x181A511F0", Slot = "14")]
		protected override void RenderSingle(ExpeditionReturnDialogSingleData single, bool isLast)
		{
		}

		// Token: 0x06020387 RID: 131975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020387")]
		[Address(RVA = "0x1A519D0", Offset = "0x1A505D0", VA = "0x181A519D0")]
		private void _RenderExped(ExpeditionReturnDialogSingleData single)
		{
		}

		// Token: 0x06020388 RID: 131976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020388")]
		[Address(RVA = "0x1A51870", Offset = "0x1A50470", VA = "0x181A51870")]
		private void _RenderCandle(ExpeditionReturnDialogSingleData single)
		{
		}

		// Token: 0x06020389 RID: 131977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020389")]
		[Address(RVA = "0x1A51C40", Offset = "0x1A50840", VA = "0x181A51C40")]
		private void _RenderNoUpgrade()
		{
		}

		// Token: 0x0602038A RID: 131978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602038A")]
		[Address(RVA = "0x1A51B30", Offset = "0x1A50730", VA = "0x181A51B30")]
		private void _RenderGuided()
		{
		}

		// Token: 0x0602038B RID: 131979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602038B")]
		[Address(RVA = "0x1A51D50", Offset = "0x1A50950", VA = "0x181A51D50")]
		private void _RenderNonGuided()
		{
		}

		// Token: 0x0602038C RID: 131980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602038C")]
		[Address(RVA = "0x1A51150", Offset = "0x1A4FD50", VA = "0x181A51150", Slot = "15")]
		protected override void PostProcessSingleList(ExpeditionReturnDialogData dialogData)
		{
		}

		// Token: 0x0602038D RID: 131981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602038D")]
		[Address(RVA = "0x1A51E60", Offset = "0x1A50A60", VA = "0x181A51E60")]
		public RL05ExpeditionReturnDialog()
		{
		}

		// Token: 0x0602038E RID: 131982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602038E")]
		[Address(RVA = "0x1A51860", Offset = "0x1A50460", VA = "0x181A51860")]
		private void <>xLuaBaseProxy_PostProcessSingleList(ExpeditionReturnDialogData P0)
		{
		}

		// Token: 0x0402B962 RID: 178530
		[Token(Token = "0x402B962")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402B963 RID: 178531
		[Token(Token = "0x402B963")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0402B964 RID: 178532
		[Token(Token = "0x402B964")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _nonLastPanel;

		// Token: 0x0402B965 RID: 178533
		[Token(Token = "0x402B965")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _lastPanel;

		// Token: 0x0402B966 RID: 178534
		[Token(Token = "0x402B966")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<RL05ExpeditionReturnDialog.TypePanel> _typePanels;

		// Token: 0x0402B967 RID: 178535
		[Token(Token = "0x402B967")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnimation;

		// Token: 0x0402B968 RID: 178536
		[Token(Token = "0x402B968")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSingle;

		// Token: 0x0402B969 RID: 178537
		[Token(Token = "0x402B969")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderExped;

		// Token: 0x0402B96A RID: 178538
		[Token(Token = "0x402B96A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCandle;

		// Token: 0x0402B96B RID: 178539
		[Token(Token = "0x402B96B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderNoUpgrade;

		// Token: 0x0402B96C RID: 178540
		[Token(Token = "0x402B96C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderGuided;

		// Token: 0x0402B96D RID: 178541
		[Token(Token = "0x402B96D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderNonGuided;

		// Token: 0x0402B96E RID: 178542
		[Token(Token = "0x402B96E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PostProcessSingleList;

		// Token: 0x0402B96F RID: 178543
		[Token(Token = "0x402B96F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055BE RID: 21950
		[Token(Token = "0x20055BE")]
		[Serializable]
		private struct TypePanel
		{
			// Token: 0x0402B970 RID: 178544
			[Token(Token = "0x402B970")]
			[FieldOffset(Offset = "0x0")]
			public PlayerRoguelikeV2.CurrentData.Troop.ExpedType type;

			// Token: 0x0402B971 RID: 178545
			[Token(Token = "0x402B971")]
			[FieldOffset(Offset = "0x8")]
			public List<GameObject> parts;
		}
	}
}
