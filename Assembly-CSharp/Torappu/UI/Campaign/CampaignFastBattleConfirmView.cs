using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006118 RID: 24856
	[Token(Token = "0x2006118")]
	public class CampaignFastBattleConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023E7B RID: 147067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E7B")]
		[Address(RVA = "0x1E86390", Offset = "0x1E84F90", VA = "0x181E86390")]
		public void Init(CampaignFastBattleConfirmView.InitOptions options)
		{
		}

		// Token: 0x06023E7C RID: 147068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E7C")]
		[Address(RVA = "0x1E864F0", Offset = "0x1E850F0", VA = "0x181E864F0")]
		public void Render(FastCampaignConfirmViewModel viewModel)
		{
		}

		// Token: 0x06023E7D RID: 147069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E7D")]
		[Address(RVA = "0x1E86320", Offset = "0x1E84F20", VA = "0x181E86320")]
		public void EventOnStartClicked()
		{
		}

		// Token: 0x06023E7E RID: 147070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E7E")]
		[Address(RVA = "0x1E862B0", Offset = "0x1E84EB0", VA = "0x181E862B0")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x06023E7F RID: 147071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E7F")]
		[Address(RVA = "0x1E86910", Offset = "0x1E85510", VA = "0x181E86910")]
		public CampaignFastBattleConfirmView()
		{
		}

		// Token: 0x04031D3E RID: 204094
		[Token(Token = "0x4031D3E")]
		private const string TARGET_SHARD_FMT = "<color=#ff3333>{0}</color> /{1}";

		// Token: 0x04031D3F RID: 204095
		[Token(Token = "0x4031D3F")]
		private const float HIDE_LIT_THRESHOLD = 0.002f;

		// Token: 0x04031D40 RID: 204096
		[Token(Token = "0x4031D40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04031D41 RID: 204097
		[Token(Token = "0x4031D41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textShard;

		// Token: 0x04031D42 RID: 204098
		[Token(Token = "0x4031D42")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objAPNote;

		// Token: 0x04031D43 RID: 204099
		[Token(Token = "0x4031D43")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _slideShardFrom;

		// Token: 0x04031D44 RID: 204100
		[Token(Token = "0x4031D44")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _slideShardTo;

		// Token: 0x04031D45 RID: 204101
		[Token(Token = "0x4031D45")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Hide the prg slider when too short")]
		private GameObject _litPrgShardFrom;

		// Token: 0x04031D46 RID: 204102
		[Token(Token = "0x4031D46")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textShardFrom;

		// Token: 0x04031D47 RID: 204103
		[Token(Token = "0x4031D47")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textShardTo;

		// Token: 0x04031D48 RID: 204104
		[Token(Token = "0x4031D48")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textConfirm;

		// Token: 0x04031D49 RID: 204105
		[Token(Token = "0x4031D49")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _layoutCostTkt;

		// Token: 0x04031D4A RID: 204106
		[Token(Token = "0x4031D4A")]
		[FieldOffset(Offset = "0x68")]
		private CampaignFastBattleConfirmView.InitOptions m_initOptions;

		// Token: 0x04031D4B RID: 204107
		[Token(Token = "0x4031D4B")]
		[FieldOffset(Offset = "0x78")]
		private FastCampaignConfirmViewModel m_viewModel;

		// Token: 0x04031D4C RID: 204108
		[Token(Token = "0x4031D4C")]
		[FieldOffset(Offset = "0x80")]
		private CampaignFastBattleConfirmView.TktAdapter m_tktAdapter;

		// Token: 0x04031D4D RID: 204109
		[Token(Token = "0x4031D4D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04031D4E RID: 204110
		[Token(Token = "0x4031D4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04031D4F RID: 204111
		[Token(Token = "0x4031D4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031D50 RID: 204112
		[Token(Token = "0x4031D50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnStartClicked;

		// Token: 0x04031D51 RID: 204113
		[Token(Token = "0x4031D51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x04031D52 RID: 204114
		[Token(Token = "0x4031D52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006119 RID: 24857
		[Token(Token = "0x2006119")]
		public struct InitOptions
		{
			// Token: 0x04031D53 RID: 204115
			[Token(Token = "0x4031D53")]
			[FieldOffset(Offset = "0x0")]
			public Action onStartClicked;

			// Token: 0x04031D54 RID: 204116
			[Token(Token = "0x4031D54")]
			[FieldOffset(Offset = "0x8")]
			public Action onCancelClicked;
		}

		// Token: 0x0200611A RID: 24858
		[Token(Token = "0x200611A")]
		private class TktAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06023E80 RID: 147072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023E80")]
			[Address(RVA = "0x1E9C480", Offset = "0x1E9B080", VA = "0x181E9C480")]
			public TktAdapter(CampaignFastBattleConfirmView closure)
			{
			}

			// Token: 0x170054CF RID: 21711
			// (get) Token: 0x06023E81 RID: 147073 RVA: 0x000C2550 File Offset: 0x000C0750
			[Token(Token = "0x170054CF")]
			public override int count
			{
				[Token(Token = "0x6023E81")]
				[Address(RVA = "0x1E9C500", Offset = "0x1E9B100", VA = "0x181E9C500", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023E82 RID: 147074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023E82")]
			[Address(RVA = "0x1E9C080", Offset = "0x1E9AC80", VA = "0x181E9C080", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031D55 RID: 204117
			[Token(Token = "0x4031D55")]
			[FieldOffset(Offset = "0x20")]
			private CampaignFastBattleConfirmView m_closure;

			// Token: 0x04031D56 RID: 204118
			[Token(Token = "0x4031D56")]
			[FieldOffset(Offset = "0x28")]
			public long updateCurTs;

			// Token: 0x04031D57 RID: 204119
			[Token(Token = "0x4031D57")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031D58 RID: 204120
			[Token(Token = "0x4031D58")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031D59 RID: 204121
			[Token(Token = "0x4031D59")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
