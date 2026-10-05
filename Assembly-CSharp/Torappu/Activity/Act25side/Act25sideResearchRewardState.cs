using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074FB RID: 29947
	[Token(Token = "0x20074FB")]
	public class Act25sideResearchRewardState : PopupFloatState, IHotfixable
	{
		// Token: 0x0602A354 RID: 172884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A354")]
		[Address(RVA = "0x25E4D30", Offset = "0x25E3930", VA = "0x1825E4D30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A355 RID: 172885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A355")]
		[Address(RVA = "0x25E4D90", Offset = "0x25E3990", VA = "0x1825E4D90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A356 RID: 172886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A356")]
		[Address(RVA = "0x25E5650", Offset = "0x25E4250", VA = "0x1825E5650")]
		private void _UpdateView()
		{
		}

		// Token: 0x0602A357 RID: 172887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A357")]
		[Address(RVA = "0x25E4FA0", Offset = "0x25E3BA0", VA = "0x1825E4FA0")]
		private List<Act25sideResearchRewardState.RewardViewModel> _GenerateItemList(string actId, string areaId)
		{
			return null;
		}

		// Token: 0x0602A358 RID: 172888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A358")]
		[Address(RVA = "0x25E5490", Offset = "0x25E4090", VA = "0x1825E5490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A359 RID: 172889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A359")]
		[Address(RVA = "0x25E5810", Offset = "0x25E4410", VA = "0x1825E5810")]
		public Act25sideResearchRewardState()
		{
		}

		// Token: 0x0602A35A RID: 172890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A35A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CA72 RID: 248434
		[Token(Token = "0x403CA72")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _view;

		// Token: 0x0403CA73 RID: 248435
		[Token(Token = "0x403CA73")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403CA74 RID: 248436
		[Token(Token = "0x403CA74")]
		[FieldOffset(Offset = "0x80")]
		private Act25sideResearchRewardState.RewardAdapter m_adpter;

		// Token: 0x0403CA75 RID: 248437
		[Token(Token = "0x403CA75")]
		[FieldOffset(Offset = "0x88")]
		private Act25sideResearchRewardStateBean m_stateBean;

		// Token: 0x0403CA76 RID: 248438
		[Token(Token = "0x403CA76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CA77 RID: 248439
		[Token(Token = "0x403CA77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CA78 RID: 248440
		[Token(Token = "0x403CA78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0403CA79 RID: 248441
		[Token(Token = "0x403CA79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenerateItemList;

		// Token: 0x0403CA7A RID: 248442
		[Token(Token = "0x403CA7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CA7B RID: 248443
		[Token(Token = "0x403CA7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074FC RID: 29948
		[Token(Token = "0x20074FC")]
		private class RewardViewModel : IComparable<Act25sideResearchRewardState.RewardViewModel>
		{
			// Token: 0x0602A35B RID: 172891 RVA: 0x000D7AD8 File Offset: 0x000D5CD8
			[Token(Token = "0x602A35B")]
			[Address(RVA = "0x25EDB70", Offset = "0x25EC770", VA = "0x1825EDB70", Slot = "4")]
			public int CompareTo(Act25sideResearchRewardState.RewardViewModel other)
			{
				return 0;
			}

			// Token: 0x0602A35C RID: 172892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A35C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RewardViewModel()
			{
			}

			// Token: 0x0403CA7C RID: 248444
			[Token(Token = "0x403CA7C")]
			[FieldOffset(Offset = "0x10")]
			public UIItemViewModel itemViewModel;

			// Token: 0x0403CA7D RID: 248445
			[Token(Token = "0x403CA7D")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0403CA7E RID: 248446
			[Token(Token = "0x403CA7E")]
			[FieldOffset(Offset = "0x1C")]
			public bool isGain;
		}

		// Token: 0x020074FD RID: 29949
		[Token(Token = "0x20074FD")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700635F RID: 25439
			// (get) Token: 0x0602A35D RID: 172893 RVA: 0x000D7AF0 File Offset: 0x000D5CF0
			[Token(Token = "0x1700635F")]
			public override int count
			{
				[Token(Token = "0x602A35D")]
				[Address(RVA = "0x25ED9C0", Offset = "0x25EC5C0", VA = "0x1825ED9C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A35E RID: 172894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A35E")]
			[Address(RVA = "0x25ED730", Offset = "0x25EC330", VA = "0x1825ED730", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A35F RID: 172895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A35F")]
			[Address(RVA = "0x25ED8E0", Offset = "0x25EC4E0", VA = "0x1825ED8E0")]
			public RewardAdapter()
			{
			}

			// Token: 0x0403CA7F RID: 248447
			[Token(Token = "0x403CA7F")]
			[FieldOffset(Offset = "0x20")]
			public List<Act25sideResearchRewardState.RewardViewModel> rewards;

			// Token: 0x0403CA80 RID: 248448
			[Token(Token = "0x403CA80")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CA81 RID: 248449
			[Token(Token = "0x403CA81")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403CA82 RID: 248450
			[Token(Token = "0x403CA82")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
