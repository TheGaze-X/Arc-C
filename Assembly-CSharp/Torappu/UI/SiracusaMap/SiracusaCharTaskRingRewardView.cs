using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F1B RID: 16155
	[Token(Token = "0x2003F1B")]
	public class SiracusaCharTaskRingRewardView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x0601915C RID: 102748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601915C")]
		[Address(RVA = "0x11B5C90", Offset = "0x11B4890", VA = "0x1811B5C90")]
		public void SetClosure(SiracusaCharTaskRingRewardState closure)
		{
		}

		// Token: 0x0601915D RID: 102749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601915D")]
		[Address(RVA = "0x11B58A0", Offset = "0x11B44A0", VA = "0x1811B58A0", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x0601915E RID: 102750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601915E")]
		[Address(RVA = "0x11B5FE0", Offset = "0x11B4BE0", VA = "0x1811B5FE0")]
		private void _RenderRewardView(bool isRetro)
		{
		}

		// Token: 0x0601915F RID: 102751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601915F")]
		[Address(RVA = "0x11B5D80", Offset = "0x11B4980", VA = "0x1811B5D80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019160 RID: 102752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019160")]
		[Address(RVA = "0x11B6160", Offset = "0x11B4D60", VA = "0x1811B6160")]
		public SiracusaCharTaskRingRewardView()
		{
		}

		// Token: 0x0401F093 RID: 127123
		[Token(Token = "0x401F093")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurrent;

		// Token: 0x0401F094 RID: 127124
		[Token(Token = "0x401F094")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMax;

		// Token: 0x0401F095 RID: 127125
		[Token(Token = "0x401F095")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRingDesc;

		// Token: 0x0401F096 RID: 127126
		[Token(Token = "0x401F096")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _itemRoot;

		// Token: 0x0401F097 RID: 127127
		[Token(Token = "0x401F097")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _placeList;

		// Token: 0x0401F098 RID: 127128
		[Token(Token = "0x401F098")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0401F099 RID: 127129
		[Token(Token = "0x401F099")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _rewardItemGo;

		// Token: 0x0401F09A RID: 127130
		[Token(Token = "0x401F09A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _btnTakeRewardGo;

		// Token: 0x0401F09B RID: 127131
		[Token(Token = "0x401F09B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnCompleteTaskGo;

		// Token: 0x0401F09C RID: 127132
		[Token(Token = "0x401F09C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0401F09D RID: 127133
		[Token(Token = "0x401F09D")]
		[FieldOffset(Offset = "0x70")]
		private SiracusaCharTaskRingRewardView.Adapter m_adapter;

		// Token: 0x0401F09E RID: 127134
		[Token(Token = "0x401F09E")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_itemCard;

		// Token: 0x0401F09F RID: 127135
		[Token(Token = "0x401F09F")]
		[FieldOffset(Offset = "0x80")]
		private SiracusaCharTaskRingModel m_ringModel;

		// Token: 0x0401F0A0 RID: 127136
		[Token(Token = "0x401F0A0")]
		[FieldOffset(Offset = "0x88")]
		private SiracusaCharTaskRingRewardState m_closure;

		// Token: 0x0401F0A1 RID: 127137
		[Token(Token = "0x401F0A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetClosure;

		// Token: 0x0401F0A2 RID: 127138
		[Token(Token = "0x401F0A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F0A3 RID: 127139
		[Token(Token = "0x401F0A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderRewardView;

		// Token: 0x0401F0A4 RID: 127140
		[Token(Token = "0x401F0A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F0A5 RID: 127141
		[Token(Token = "0x401F0A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F1C RID: 16156
		[Token(Token = "0x2003F1C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06019162 RID: 102754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019162")]
			[Address(RVA = "0x11C5060", Offset = "0x11C3C60", VA = "0x1811C5060")]
			public Adapter(SiracusaCharTaskRingRewardView closure)
			{
			}

			// Token: 0x17003C03 RID: 15363
			// (get) Token: 0x06019163 RID: 102755 RVA: 0x0009CF48 File Offset: 0x0009B148
			[Token(Token = "0x17003C03")]
			public override int count
			{
				[Token(Token = "0x6019163")]
				[Address(RVA = "0x11C53A0", Offset = "0x11C3FA0", VA = "0x1811C53A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019164 RID: 102756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019164")]
			[Address(RVA = "0x11C4910", Offset = "0x11C3510", VA = "0x1811C4910", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401F0A6 RID: 127142
			[Token(Token = "0x401F0A6")]
			[FieldOffset(Offset = "0x20")]
			private SiracusaCharTaskRingRewardView m_closure;

			// Token: 0x0401F0A7 RID: 127143
			[Token(Token = "0x401F0A7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F0A8 RID: 127144
			[Token(Token = "0x401F0A8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F0A9 RID: 127145
			[Token(Token = "0x401F0A9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
