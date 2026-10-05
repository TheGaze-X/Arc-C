using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E0A RID: 19978
	[Token(Token = "0x2004E0A")]
	public class NameCardV2EquipmentCollectionModuleView : NameCardV2BaseRemovableModuleView<NameCardV2EquipmentCollectionModuleModel>
	{
		// Token: 0x0601DDAC RID: 122284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDAC")]
		[Address(RVA = "0x1775850", Offset = "0x1774450", VA = "0x181775850", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2EquipmentCollectionModuleModel model)
		{
		}

		// Token: 0x0601DDAD RID: 122285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDAD")]
		[Address(RVA = "0x1775470", Offset = "0x1774070", VA = "0x181775470", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DDAE RID: 122286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDAE")]
		[Address(RVA = "0x1775A90", Offset = "0x1774690", VA = "0x181775A90")]
		public void SwitchModuleStyle()
		{
		}

		// Token: 0x0601DDAF RID: 122287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDAF")]
		[Address(RVA = "0x1775D00", Offset = "0x1774900", VA = "0x181775D00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DDB0 RID: 122288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDB0")]
		[Address(RVA = "0x1775E40", Offset = "0x1774A40", VA = "0x181775E40")]
		public NameCardV2EquipmentCollectionModuleView()
		{
		}

		// Token: 0x0601DDB1 RID: 122289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDB1")]
		[Address(RVA = "0x1772BA0", Offset = "0x17717A0", VA = "0x181772BA0")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x0402791D RID: 162077
		[Token(Token = "0x402791D")]
		private const int COLLECTION_INFO_SLOT = 3;

		// Token: 0x0402791E RID: 162078
		[Token(Token = "0x402791E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Colored")]
		private Image _bgImg;

		// Token: 0x0402791F RID: 162079
		[Token(Token = "0x402791F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Colored")]
		private Image[] _coloredIcons;

		// Token: 0x04027920 RID: 162080
		[Token(Token = "0x4027920")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Colored")]
		private Text[] _coloredTexts;

		// Token: 0x04027921 RID: 162081
		[Token(Token = "0x4027921")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _switchIconAnim;

		// Token: 0x04027922 RID: 162082
		[Token(Token = "0x4027922")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject[] _switchIconGos;

		// Token: 0x04027923 RID: 162083
		[Token(Token = "0x4027923")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private SimpleLayoutContent _collectionInfosContent;

		// Token: 0x04027924 RID: 162084
		[Token(Token = "0x4027924")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIColorGraphic _itemTextColorGraphic;

		// Token: 0x04027925 RID: 162085
		[Token(Token = "0x4027925")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInited;

		// Token: 0x04027926 RID: 162086
		[Token(Token = "0x4027926")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_switchIconTween;

		// Token: 0x04027927 RID: 162087
		[Token(Token = "0x4027927")]
		[FieldOffset(Offset = "0x108")]
		private NameCardV2EquipmentCollectionModuleModel m_cachedModel;

		// Token: 0x04027928 RID: 162088
		[Token(Token = "0x4027928")]
		[FieldOffset(Offset = "0x110")]
		private NameCardV2EquipmentCollectionModuleView.CollectionInfoAdapter m_adapter;

		// Token: 0x04027929 RID: 162089
		[Token(Token = "0x4027929")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x0402792A RID: 162090
		[Token(Token = "0x402792A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0402792B RID: 162091
		[Token(Token = "0x402792B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SwitchModuleStyle;

		// Token: 0x0402792C RID: 162092
		[Token(Token = "0x402792C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402792D RID: 162093
		[Token(Token = "0x402792D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E0B RID: 19979
		[Token(Token = "0x2004E0B")]
		public class VirtualView : NameCardV2RemovableModuleVirtualView<NameCardV2EquipmentCollectionModuleView, NameCardV2EquipmentCollectionModuleModel>
		{
			// Token: 0x0601DDB2 RID: 122290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDB2")]
			[Address(RVA = "0x177EFC0", Offset = "0x177DBC0", VA = "0x18177EFC0")]
			public VirtualView(NameCardV2BaseRemovableModuleView prefab, NameCardV2RemovableModuleBaseModel model)
			{
			}

			// Token: 0x0402792E RID: 162094
			[Token(Token = "0x402792E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004E0C RID: 19980
		[Token(Token = "0x2004E0C")]
		private class CollectionInfoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601DDB3 RID: 122291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDB3")]
			[Address(RVA = "0x1769140", Offset = "0x1767D40", VA = "0x181769140")]
			public CollectionInfoAdapter(NameCardV2EquipmentCollectionModuleView closure)
			{
			}

			// Token: 0x1700460D RID: 17933
			// (get) Token: 0x0601DDB4 RID: 122292 RVA: 0x000AC8A8 File Offset: 0x000AAAA8
			[Token(Token = "0x1700460D")]
			public override int count
			{
				[Token(Token = "0x601DDB4")]
				[Address(RVA = "0x17691C0", Offset = "0x1767DC0", VA = "0x1817691C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DDB5 RID: 122293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DDB5")]
			[Address(RVA = "0x1768EF0", Offset = "0x1767AF0", VA = "0x181768EF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402792F RID: 162095
			[Token(Token = "0x402792F")]
			[FieldOffset(Offset = "0x20")]
			private NameCardV2EquipmentCollectionModuleView m_closure;

			// Token: 0x04027930 RID: 162096
			[Token(Token = "0x4027930")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027931 RID: 162097
			[Token(Token = "0x4027931")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027932 RID: 162098
			[Token(Token = "0x4027932")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
