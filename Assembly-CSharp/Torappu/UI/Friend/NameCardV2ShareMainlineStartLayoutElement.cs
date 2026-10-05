using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DDB RID: 19931
	[Token(Token = "0x2004DDB")]
	public class NameCardV2ShareMainlineStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DCC9 RID: 122057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCC9")]
		[Address(RVA = "0x17665A0", Offset = "0x17651A0", VA = "0x1817665A0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DCCA RID: 122058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCCA")]
		[Address(RVA = "0x17666F0", Offset = "0x17652F0", VA = "0x1817666F0")]
		public NameCardV2ShareMainlineStartLayoutElement()
		{
		}

		// Token: 0x04027751 RID: 161617
		[Token(Token = "0x4027751")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x04027752 RID: 161618
		[Token(Token = "0x4027752")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _mainlineIcon;

		// Token: 0x04027753 RID: 161619
		[Token(Token = "0x4027753")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _constText;

		// Token: 0x04027754 RID: 161620
		[Token(Token = "0x4027754")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _chapterEnName;

		// Token: 0x04027755 RID: 161621
		[Token(Token = "0x4027755")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stageProgress;

		// Token: 0x04027756 RID: 161622
		[Token(Token = "0x4027756")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _allComplete;

		// Token: 0x04027757 RID: 161623
		[Token(Token = "0x4027757")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _chapterImage;

		// Token: 0x04027758 RID: 161624
		[Token(Token = "0x4027758")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x04027759 RID: 161625
		[Token(Token = "0x4027759")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DDC RID: 19932
		[Token(Token = "0x2004DDC")]
		public class NameCardV2ShareMainlineModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DCCB RID: 122059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCCB")]
			[Address(RVA = "0x1765400", Offset = "0x1764000", VA = "0x181765400", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCCC RID: 122060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCCC")]
			[Address(RVA = "0x1765B00", Offset = "0x1764700", VA = "0x181765B00")]
			public void InitCollector(NameCardV2ShareMainlineStartLayoutElement closure)
			{
			}

			// Token: 0x170045F0 RID: 17904
			// (get) Token: 0x0601DCCD RID: 122061 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCCE RID: 122062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F0")]
			public CrossAppShareImageModel bgRectModel
			{
				[Token(Token = "0x601DCCD")]
				[Address(RVA = "0x1765C40", Offset = "0x1764840", VA = "0x181765C40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCCE")]
				[Address(RVA = "0x1765F00", Offset = "0x1764B00", VA = "0x181765F00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045F1 RID: 17905
			// (get) Token: 0x0601DCCF RID: 122063 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCD0 RID: 122064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F1")]
			public CrossAppShareImageModel mainlineIconModel
			{
				[Token(Token = "0x601DCCF")]
				[Address(RVA = "0x1765DC0", Offset = "0x17649C0", VA = "0x181765DC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCD0")]
				[Address(RVA = "0x1766100", Offset = "0x1764D00", VA = "0x181766100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045F2 RID: 17906
			// (get) Token: 0x0601DCD1 RID: 122065 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCD2 RID: 122066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F2")]
			public CrossAppShareTextModel constTextModel
			{
				[Token(Token = "0x601DCD1")]
				[Address(RVA = "0x1765D60", Offset = "0x1764960", VA = "0x181765D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCD2")]
				[Address(RVA = "0x1766080", Offset = "0x1764C80", VA = "0x181766080")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045F3 RID: 17907
			// (get) Token: 0x0601DCD3 RID: 122067 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCD4 RID: 122068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F3")]
			public CrossAppShareTextModel chapterEnNameModel
			{
				[Token(Token = "0x601DCD3")]
				[Address(RVA = "0x1765CA0", Offset = "0x17648A0", VA = "0x181765CA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCD4")]
				[Address(RVA = "0x1765F80", Offset = "0x1764B80", VA = "0x181765F80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045F4 RID: 17908
			// (get) Token: 0x0601DCD5 RID: 122069 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCD6 RID: 122070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F4")]
			public CrossAppShareTextModel stageProgressModel
			{
				[Token(Token = "0x601DCD5")]
				[Address(RVA = "0x1765E20", Offset = "0x1764A20", VA = "0x181765E20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCD6")]
				[Address(RVA = "0x1766180", Offset = "0x1764D80", VA = "0x181766180")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045F5 RID: 17909
			// (get) Token: 0x0601DCD7 RID: 122071 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCD8 RID: 122072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F5")]
			public CrossAppShareTextModel allCompleteModel
			{
				[Token(Token = "0x601DCD7")]
				[Address(RVA = "0x1765BE0", Offset = "0x17647E0", VA = "0x181765BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCD8")]
				[Address(RVA = "0x1765E80", Offset = "0x1764A80", VA = "0x181765E80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045F6 RID: 17910
			// (get) Token: 0x0601DCD9 RID: 122073 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCDA RID: 122074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F6")]
			public CrossAppShareImageModel chapterImageModel
			{
				[Token(Token = "0x601DCD9")]
				[Address(RVA = "0x1765D00", Offset = "0x1764900", VA = "0x181765D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCDA")]
				[Address(RVA = "0x1766000", Offset = "0x1764C00", VA = "0x181766000")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCDB RID: 122075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCDB")]
			[Address(RVA = "0x1765B80", Offset = "0x1764780", VA = "0x181765B80")]
			public NameCardV2ShareMainlineModelCollector()
			{
			}

			// Token: 0x0402775A RID: 161626
			[Token(Token = "0x402775A")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareMainlineStartLayoutElement m_closure;

			// Token: 0x04027762 RID: 161634
			[Token(Token = "0x4027762")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04027763 RID: 161635
			[Token(Token = "0x4027763")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027764 RID: 161636
			[Token(Token = "0x4027764")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_bgRectModel;

			// Token: 0x04027765 RID: 161637
			[Token(Token = "0x4027765")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_bgRectModel;

			// Token: 0x04027766 RID: 161638
			[Token(Token = "0x4027766")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_mainlineIconModel;

			// Token: 0x04027767 RID: 161639
			[Token(Token = "0x4027767")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_mainlineIconModel;

			// Token: 0x04027768 RID: 161640
			[Token(Token = "0x4027768")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_constTextModel;

			// Token: 0x04027769 RID: 161641
			[Token(Token = "0x4027769")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_constTextModel;

			// Token: 0x0402776A RID: 161642
			[Token(Token = "0x402776A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_chapterEnNameModel;

			// Token: 0x0402776B RID: 161643
			[Token(Token = "0x402776B")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_chapterEnNameModel;

			// Token: 0x0402776C RID: 161644
			[Token(Token = "0x402776C")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_stageProgressModel;

			// Token: 0x0402776D RID: 161645
			[Token(Token = "0x402776D")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_set_stageProgressModel;

			// Token: 0x0402776E RID: 161646
			[Token(Token = "0x402776E")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_allCompleteModel;

			// Token: 0x0402776F RID: 161647
			[Token(Token = "0x402776F")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_set_allCompleteModel;

			// Token: 0x04027770 RID: 161648
			[Token(Token = "0x4027770")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_chapterImageModel;

			// Token: 0x04027771 RID: 161649
			[Token(Token = "0x4027771")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_set_chapterImageModel;

			// Token: 0x04027772 RID: 161650
			[Token(Token = "0x4027772")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
