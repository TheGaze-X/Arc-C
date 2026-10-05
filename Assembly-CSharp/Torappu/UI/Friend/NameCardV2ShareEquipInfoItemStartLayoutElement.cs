using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DD5 RID: 19925
	[Token(Token = "0x2004DD5")]
	public class NameCardV2ShareEquipInfoItemStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DCB1 RID: 122033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCB1")]
		[Address(RVA = "0x1764BC0", Offset = "0x17637C0", VA = "0x181764BC0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DCB2 RID: 122034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCB2")]
		[Address(RVA = "0x1764D20", Offset = "0x1763920", VA = "0x181764D20")]
		public NameCardV2ShareEquipInfoItemStartLayoutElement()
		{
		}

		// Token: 0x04027723 RID: 161571
		[Token(Token = "0x4027723")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _totalObject;

		// Token: 0x04027724 RID: 161572
		[Token(Token = "0x4027724")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtCurCount;

		// Token: 0x04027725 RID: 161573
		[Token(Token = "0x4027725")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtTotalCount;

		// Token: 0x04027726 RID: 161574
		[Token(Token = "0x4027726")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x04027727 RID: 161575
		[Token(Token = "0x4027727")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private NameCardV2EquipmentCollectionInfoItemView _view;

		// Token: 0x04027728 RID: 161576
		[Token(Token = "0x4027728")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x04027729 RID: 161577
		[Token(Token = "0x4027729")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DD6 RID: 19926
		[Token(Token = "0x2004DD6")]
		public class NameCardV2ShareEquipInfoItemModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DCB3 RID: 122035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCB3")]
			[Address(RVA = "0x1764490", Offset = "0x1763090", VA = "0x181764490")]
			public void InitCollector(NameCardV2ShareEquipInfoItemStartLayoutElement closure)
			{
			}

			// Token: 0x170045EB RID: 17899
			// (get) Token: 0x0601DCB4 RID: 122036 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCB5 RID: 122037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045EB")]
			public CrossAppShareObjectActiveModel totalModel
			{
				[Token(Token = "0x601DCB4")]
				[Address(RVA = "0x1764690", Offset = "0x1763290", VA = "0x181764690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCB5")]
				[Address(RVA = "0x1764870", Offset = "0x1763470", VA = "0x181764870")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045EC RID: 17900
			// (get) Token: 0x0601DCB6 RID: 122038 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCB7 RID: 122039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045EC")]
			public CrossAppShareTextModel curCountModel
			{
				[Token(Token = "0x601DCB6")]
				[Address(RVA = "0x1764570", Offset = "0x1763170", VA = "0x181764570")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCB7")]
				[Address(RVA = "0x17646F0", Offset = "0x17632F0", VA = "0x1817646F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045ED RID: 17901
			// (get) Token: 0x0601DCB8 RID: 122040 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCB9 RID: 122041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045ED")]
			public CrossAppShareTextModel totalCountModel
			{
				[Token(Token = "0x601DCB8")]
				[Address(RVA = "0x1764630", Offset = "0x1763230", VA = "0x181764630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCB9")]
				[Address(RVA = "0x17647F0", Offset = "0x17633F0", VA = "0x1817647F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045EE RID: 17902
			// (get) Token: 0x0601DCBA RID: 122042 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCBB RID: 122043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045EE")]
			public CrossAppShareTextModel nameModel
			{
				[Token(Token = "0x601DCBA")]
				[Address(RVA = "0x17645D0", Offset = "0x17631D0", VA = "0x1817645D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCBB")]
				[Address(RVA = "0x1764770", Offset = "0x1763370", VA = "0x181764770")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCBC RID: 122044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCBC")]
			[Address(RVA = "0x1764030", Offset = "0x1762C30", VA = "0x181764030", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCBD RID: 122045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCBD")]
			[Address(RVA = "0x1764510", Offset = "0x1763110", VA = "0x181764510")]
			public NameCardV2ShareEquipInfoItemModelCollector()
			{
			}

			// Token: 0x0402772A RID: 161578
			[Token(Token = "0x402772A")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareEquipInfoItemStartLayoutElement m_closure;

			// Token: 0x0402772B RID: 161579
			[Token(Token = "0x402772B")]
			[FieldOffset(Offset = "0x30")]
			public bool isShow;

			// Token: 0x04027730 RID: 161584
			[Token(Token = "0x4027730")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027731 RID: 161585
			[Token(Token = "0x4027731")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_totalModel;

			// Token: 0x04027732 RID: 161586
			[Token(Token = "0x4027732")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_totalModel;

			// Token: 0x04027733 RID: 161587
			[Token(Token = "0x4027733")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_curCountModel;

			// Token: 0x04027734 RID: 161588
			[Token(Token = "0x4027734")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_curCountModel;

			// Token: 0x04027735 RID: 161589
			[Token(Token = "0x4027735")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_totalCountModel;

			// Token: 0x04027736 RID: 161590
			[Token(Token = "0x4027736")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_totalCountModel;

			// Token: 0x04027737 RID: 161591
			[Token(Token = "0x4027737")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_nameModel;

			// Token: 0x04027738 RID: 161592
			[Token(Token = "0x4027738")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_nameModel;

			// Token: 0x04027739 RID: 161593
			[Token(Token = "0x4027739")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x0402773A RID: 161594
			[Token(Token = "0x402773A")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
