using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044F0 RID: 17648
	[Token(Token = "0x20044F0")]
	public class RoguelikeTopicMonthTaskView : DataBinder<RoguelikeTopicMonthTaskProperty>
	{
		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x0601AF0E RID: 110350 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AF0F RID: 110351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FFA")]
		public Action<RoguelikeTopicMonthTaskModel> onTaskRefreshAction
		{
			[Token(Token = "0x601AF0E")]
			[Address(RVA = "0x142C2C0", Offset = "0x142AEC0", VA = "0x18142C2C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AF0F")]
			[Address(RVA = "0x142C320", Offset = "0x142AF20", VA = "0x18142C320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AF10 RID: 110352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF10")]
		[Address(RVA = "0x142B720", Offset = "0x142A320", VA = "0x18142B720", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicMonthTaskProperty property)
		{
		}

		// Token: 0x0601AF11 RID: 110353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF11")]
		[Address(RVA = "0x142C0F0", Offset = "0x142ACF0", VA = "0x18142C0F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF12 RID: 110354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF12")]
		[Address(RVA = "0x142BF30", Offset = "0x142AB30", VA = "0x18142BF30")]
		public void PlayAnim(RoguelikeTopicMonthTaskModel taskModel)
		{
		}

		// Token: 0x0601AF13 RID: 110355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF13")]
		[Address(RVA = "0x142C1C0", Offset = "0x142ADC0", VA = "0x18142C1C0")]
		public RoguelikeTopicMonthTaskView()
		{
		}

		// Token: 0x040228F0 RID: 141552
		[Token(Token = "0x40228F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _taskList;

		// Token: 0x040228F1 RID: 141553
		[Token(Token = "0x40228F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRule;

		// Token: 0x040228F2 RID: 141554
		[Token(Token = "0x40228F2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRefreshCount;

		// Token: 0x040228F3 RID: 141555
		[Token(Token = "0x40228F3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUpdateTime;

		// Token: 0x040228F4 RID: 141556
		[Token(Token = "0x40228F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUpdateCaption;

		// Token: 0x040228F5 RID: 141557
		[Token(Token = "0x40228F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textFinishCaption;

		// Token: 0x040228F6 RID: 141558
		[Token(Token = "0x40228F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgGreyMask;

		// Token: 0x040228F8 RID: 141560
		[Token(Token = "0x40228F8")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x040228F9 RID: 141561
		[Token(Token = "0x40228F9")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicMonthTaskView.Adapter m_adapter;

		// Token: 0x040228FA RID: 141562
		[Token(Token = "0x40228FA")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040228FB RID: 141563
		[Token(Token = "0x40228FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTaskRefreshAction;

		// Token: 0x040228FC RID: 141564
		[Token(Token = "0x40228FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTaskRefreshAction;

		// Token: 0x040228FD RID: 141565
		[Token(Token = "0x40228FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040228FE RID: 141566
		[Token(Token = "0x40228FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040228FF RID: 141567
		[Token(Token = "0x40228FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x04022900 RID: 141568
		[Token(Token = "0x4022900")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044F1 RID: 17649
		[Token(Token = "0x20044F1")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AF14 RID: 110356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF14")]
			[Address(RVA = "0x1416880", Offset = "0x1415480", VA = "0x181416880")]
			public void SetData(RoguelikeTopicMonthTaskListModel listModel, Action<RoguelikeTopicMonthTaskModel> onTaskRefreshAction, RoguelikeTopicMonthTaskStyle style)
			{
			}

			// Token: 0x17003FFB RID: 16379
			// (get) Token: 0x0601AF15 RID: 110357 RVA: 0x000A3B60 File Offset: 0x000A1D60
			[Token(Token = "0x17003FFB")]
			public override int count
			{
				[Token(Token = "0x601AF15")]
				[Address(RVA = "0x14169A0", Offset = "0x14155A0", VA = "0x1814169A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AF16 RID: 110358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AF16")]
			[Address(RVA = "0x1416640", Offset = "0x1415240", VA = "0x181416640", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AF17 RID: 110359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF17")]
			[Address(RVA = "0x1416530", Offset = "0x1415130", VA = "0x181416530")]
			public void PlayAnim(int position)
			{
			}

			// Token: 0x0601AF18 RID: 110360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF18")]
			[Address(RVA = "0x1416940", Offset = "0x1415540", VA = "0x181416940")]
			public Adapter()
			{
			}

			// Token: 0x04022901 RID: 141569
			[Token(Token = "0x4022901")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicMonthTaskListModel m_listModel;

			// Token: 0x04022902 RID: 141570
			[Token(Token = "0x4022902")]
			[FieldOffset(Offset = "0x28")]
			private Action<RoguelikeTopicMonthTaskModel> m_onTaskRefreshAction;

			// Token: 0x04022903 RID: 141571
			[Token(Token = "0x4022903")]
			[FieldOffset(Offset = "0x30")]
			private RoguelikeTopicMonthTaskStyle m_style;

			// Token: 0x04022904 RID: 141572
			[Token(Token = "0x4022904")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04022905 RID: 141573
			[Token(Token = "0x4022905")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022906 RID: 141574
			[Token(Token = "0x4022906")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04022907 RID: 141575
			[Token(Token = "0x4022907")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayAnim;

			// Token: 0x04022908 RID: 141576
			[Token(Token = "0x4022908")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
