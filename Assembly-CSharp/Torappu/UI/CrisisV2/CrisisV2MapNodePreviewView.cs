using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059B0 RID: 22960
	[Token(Token = "0x20059B0")]
	public class CrisisV2MapNodePreviewView : DataBinder<CrisisV2MapProp>, IHotfixable
	{
		// Token: 0x0602177D RID: 137085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602177D")]
		[Address(RVA = "0x1BD23E0", Offset = "0x1BD0FE0", VA = "0x181BD23E0", Slot = "7")]
		public override void OnValueChanged(CrisisV2MapProp prop)
		{
		}

		// Token: 0x0602177E RID: 137086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602177E")]
		[Address(RVA = "0x1BD26B0", Offset = "0x1BD12B0", VA = "0x181BD26B0")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0602177F RID: 137087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602177F")]
		[Address(RVA = "0x1BD2A10", Offset = "0x1BD1610", VA = "0x181BD2A10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021780 RID: 137088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021780")]
		[Address(RVA = "0x1BD27D0", Offset = "0x1BD13D0", VA = "0x181BD27D0")]
		private string _GetProcessedPreviewDesc(CrisisV2MapModel mapModel, ref CrisisV2PreviewInfo previewInfo)
		{
			return null;
		}

		// Token: 0x06021781 RID: 137089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021781")]
		[Address(RVA = "0x1BD2350", Offset = "0x1BD0F50", VA = "0x181BD2350")]
		public void OnClosePreviewClicked()
		{
		}

		// Token: 0x06021782 RID: 137090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021782")]
		[Address(RVA = "0x1BD2E90", Offset = "0x1BD1A90", VA = "0x181BD2E90")]
		private void _OnHidePreviewComplete()
		{
		}

		// Token: 0x06021783 RID: 137091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021783")]
		[Address(RVA = "0x1BD2F20", Offset = "0x1BD1B20", VA = "0x181BD2F20")]
		public CrisisV2MapNodePreviewView()
		{
		}

		// Token: 0x0402DB4C RID: 187212
		[Token(Token = "0x402DB4C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _previewTitleText;

		// Token: 0x0402DB4D RID: 187213
		[Token(Token = "0x402DB4D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _previewDescText;

		// Token: 0x0402DB4E RID: 187214
		[Token(Token = "0x402DB4E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x0402DB4F RID: 187215
		[Token(Token = "0x402DB4F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _requiredRuneContent;

		// Token: 0x0402DB50 RID: 187216
		[Token(Token = "0x402DB50")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _requiredRuneGo;

		// Token: 0x0402DB51 RID: 187217
		[Token(Token = "0x402DB51")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _runeToggle;

		// Token: 0x0402DB52 RID: 187218
		[Token(Token = "0x402DB52")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _requiredBagContent;

		// Token: 0x0402DB53 RID: 187219
		[Token(Token = "0x402DB53")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _requiredBagGo;

		// Token: 0x0402DB54 RID: 187220
		[Token(Token = "0x402DB54")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _bagToggle;

		// Token: 0x0402DB55 RID: 187221
		[Token(Token = "0x402DB55")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _previewBackBtn;

		// Token: 0x0402DB56 RID: 187222
		[Token(Token = "0x402DB56")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelTutorialFocus;

		// Token: 0x0402DB57 RID: 187223
		[Token(Token = "0x402DB57")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0402DB58 RID: 187224
		[Token(Token = "0x402DB58")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _switchDuration;

		// Token: 0x0402DB59 RID: 187225
		[Token(Token = "0x402DB59")]
		[FieldOffset(Offset = "0x90")]
		private CrisisV2MapModel m_mapModel;

		// Token: 0x0402DB5A RID: 187226
		[Token(Token = "0x402DB5A")]
		[FieldOffset(Offset = "0x98")]
		private CrisisV2PreviewInfo m_previewInfo;

		// Token: 0x0402DB5B RID: 187227
		[Token(Token = "0x402DB5B")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_initIfNot;

		// Token: 0x0402DB5C RID: 187228
		[Token(Token = "0x402DB5C")]
		[FieldOffset(Offset = "0xD8")]
		private CrisisV2MapNodePreviewView.RewardAdapter m_rewardAdapter;

		// Token: 0x0402DB5D RID: 187229
		[Token(Token = "0x402DB5D")]
		[FieldOffset(Offset = "0xE0")]
		private CrisisV2MapNodePreviewView.RelateRuneAdapter m_relateRuneAdapter;

		// Token: 0x0402DB5E RID: 187230
		[Token(Token = "0x402DB5E")]
		[FieldOffset(Offset = "0xE8")]
		private CrisisV2MapNodePreviewView.RelateBagAdapter m_relateBagAdapter;

		// Token: 0x0402DB5F RID: 187231
		[Token(Token = "0x402DB5F")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402DB60 RID: 187232
		[Token(Token = "0x402DB60")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DB61 RID: 187233
		[Token(Token = "0x402DB61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DB62 RID: 187234
		[Token(Token = "0x402DB62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x0402DB63 RID: 187235
		[Token(Token = "0x402DB63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DB64 RID: 187236
		[Token(Token = "0x402DB64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetProcessedPreviewDesc;

		// Token: 0x0402DB65 RID: 187237
		[Token(Token = "0x402DB65")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClosePreviewClicked;

		// Token: 0x0402DB66 RID: 187238
		[Token(Token = "0x402DB66")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnHidePreviewComplete;

		// Token: 0x0402DB67 RID: 187239
		[Token(Token = "0x402DB67")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059B1 RID: 22961
		[Token(Token = "0x20059B1")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06021784 RID: 137092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021784")]
			[Address(RVA = "0x1BE6C40", Offset = "0x1BE5840", VA = "0x181BE6C40")]
			public RewardAdapter(CrisisV2MapNodePreviewView closure)
			{
			}

			// Token: 0x17004EAF RID: 20143
			// (get) Token: 0x06021785 RID: 137093 RVA: 0x000BA5E8 File Offset: 0x000B87E8
			[Token(Token = "0x17004EAF")]
			public override int count
			{
				[Token(Token = "0x6021785")]
				[Address(RVA = "0x1BE6CC0", Offset = "0x1BE58C0", VA = "0x181BE6CC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021786 RID: 137094 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021786")]
			[Address(RVA = "0x1BE6A60", Offset = "0x1BE5660", VA = "0x181BE6A60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402DB68 RID: 187240
			[Token(Token = "0x402DB68")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2MapNodePreviewView m_closure;

			// Token: 0x0402DB69 RID: 187241
			[Token(Token = "0x402DB69")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DB6A RID: 187242
			[Token(Token = "0x402DB6A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DB6B RID: 187243
			[Token(Token = "0x402DB6B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020059B2 RID: 22962
		[Token(Token = "0x20059B2")]
		private class RelateRuneAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06021787 RID: 137095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021787")]
			[Address(RVA = "0x1BE6920", Offset = "0x1BE5520", VA = "0x181BE6920")]
			public RelateRuneAdapter(CrisisV2MapNodePreviewView closure)
			{
			}

			// Token: 0x17004EB0 RID: 20144
			// (get) Token: 0x06021788 RID: 137096 RVA: 0x000BA600 File Offset: 0x000B8800
			[Token(Token = "0x17004EB0")]
			public override int count
			{
				[Token(Token = "0x6021788")]
				[Address(RVA = "0x1BE69A0", Offset = "0x1BE55A0", VA = "0x181BE69A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021789 RID: 137097 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021789")]
			[Address(RVA = "0x1BE6530", Offset = "0x1BE5130", VA = "0x181BE6530", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402DB6C RID: 187244
			[Token(Token = "0x402DB6C")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2MapNodePreviewView m_closure;

			// Token: 0x0402DB6D RID: 187245
			[Token(Token = "0x402DB6D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DB6E RID: 187246
			[Token(Token = "0x402DB6E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DB6F RID: 187247
			[Token(Token = "0x402DB6F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020059B3 RID: 22963
		[Token(Token = "0x20059B3")]
		private class RelateBagAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602178A RID: 137098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602178A")]
			[Address(RVA = "0x1BE63F0", Offset = "0x1BE4FF0", VA = "0x181BE63F0")]
			public RelateBagAdapter(CrisisV2MapNodePreviewView closure)
			{
			}

			// Token: 0x17004EB1 RID: 20145
			// (get) Token: 0x0602178B RID: 137099 RVA: 0x000BA618 File Offset: 0x000B8818
			[Token(Token = "0x17004EB1")]
			public override int count
			{
				[Token(Token = "0x602178B")]
				[Address(RVA = "0x1BE6470", Offset = "0x1BE5070", VA = "0x181BE6470", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602178C RID: 137100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602178C")]
			[Address(RVA = "0x1BE5ED0", Offset = "0x1BE4AD0", VA = "0x181BE5ED0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402DB70 RID: 187248
			[Token(Token = "0x402DB70")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2MapNodePreviewView m_closure;

			// Token: 0x0402DB71 RID: 187249
			[Token(Token = "0x402DB71")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DB72 RID: 187250
			[Token(Token = "0x402DB72")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DB73 RID: 187251
			[Token(Token = "0x402DB73")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020059B4 RID: 22964
		[Token(Token = "0x20059B4")]
		public class PreviewSlotParam : IHotfixable
		{
			// Token: 0x0602178D RID: 137101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602178D")]
			[Address(RVA = "0x1BE5E70", Offset = "0x1BE4A70", VA = "0x181BE5E70")]
			public PreviewSlotParam()
			{
			}

			// Token: 0x0402DB74 RID: 187252
			[Token(Token = "0x402DB74")]
			[FieldOffset(Offset = "0x10")]
			public CrisisV2MapModel.ViewType viewType;

			// Token: 0x0402DB75 RID: 187253
			[Token(Token = "0x402DB75")]
			[FieldOffset(Offset = "0x18")]
			public string bagOrNodeId;

			// Token: 0x0402DB76 RID: 187254
			[Token(Token = "0x402DB76")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
