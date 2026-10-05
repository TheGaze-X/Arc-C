using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004747 RID: 18247
	[Token(Token = "0x2004747")]
	public class RecruitSpecialCharPortGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA38 RID: 113208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA38")]
		[Address(RVA = "0x15043A0", Offset = "0x1502FA0", VA = "0x1815043A0")]
		public void Render(RecruitSpecialCharPortGroupView.Input input)
		{
		}

		// Token: 0x0601BA39 RID: 113209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA39")]
		[Address(RVA = "0x15045E0", Offset = "0x15031E0", VA = "0x1815045E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BA3A RID: 113210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA3A")]
		[Address(RVA = "0x1504700", Offset = "0x1503300", VA = "0x181504700")]
		public RecruitSpecialCharPortGroupView()
		{
		}

		// Token: 0x04023DAB RID: 146859
		[Token(Token = "0x4023DAB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04023DAC RID: 146860
		[Token(Token = "0x4023DAC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgStarIcon;

		// Token: 0x04023DAD RID: 146861
		[Token(Token = "0x4023DAD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSplitLine;

		// Token: 0x04023DAE RID: 146862
		[Token(Token = "0x4023DAE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04023DAF RID: 146863
		[Token(Token = "0x4023DAF")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04023DB0 RID: 146864
		[Token(Token = "0x4023DB0")]
		[FieldOffset(Offset = "0x40")]
		private RecruitSpecialCharPortGroupView.Adapter m_adapter;

		// Token: 0x04023DB1 RID: 146865
		[Token(Token = "0x4023DB1")]
		[FieldOffset(Offset = "0x48")]
		private JArrayWrapper m_cachedCharIdList;

		// Token: 0x04023DB2 RID: 146866
		[Token(Token = "0x4023DB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DB3 RID: 146867
		[Token(Token = "0x4023DB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023DB4 RID: 146868
		[Token(Token = "0x4023DB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004748 RID: 18248
		[Token(Token = "0x2004748")]
		public class Input
		{
			// Token: 0x0601BA3B RID: 113211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BA3B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04023DB5 RID: 146869
			[Token(Token = "0x4023DB5")]
			[FieldOffset(Offset = "0x10")]
			public JArrayWrapper upCharIdList;

			// Token: 0x04023DB6 RID: 146870
			[Token(Token = "0x4023DB6")]
			[FieldOffset(Offset = "0x18")]
			public RarityRank rarityRank;

			// Token: 0x04023DB7 RID: 146871
			[Token(Token = "0x4023DB7")]
			[FieldOffset(Offset = "0x20")]
			public string titleText;

			// Token: 0x04023DB8 RID: 146872
			[Token(Token = "0x4023DB8")]
			[FieldOffset(Offset = "0x28")]
			public bool isEnd;
		}

		// Token: 0x02004749 RID: 18249
		[Token(Token = "0x2004749")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601BA3C RID: 113212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BA3C")]
			[Address(RVA = "0x14F0750", Offset = "0x14EF350", VA = "0x1814F0750")]
			public Adapter(RecruitSpecialCharPortGroupView closure)
			{
			}

			// Token: 0x170041B9 RID: 16825
			// (get) Token: 0x0601BA3D RID: 113213 RVA: 0x000A5B40 File Offset: 0x000A3D40
			[Token(Token = "0x170041B9")]
			public override int count
			{
				[Token(Token = "0x601BA3D")]
				[Address(RVA = "0x14F07D0", Offset = "0x14EF3D0", VA = "0x1814F07D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BA3E RID: 113214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BA3E")]
			[Address(RVA = "0x14F05C0", Offset = "0x14EF1C0", VA = "0x1814F05C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04023DB9 RID: 146873
			[Token(Token = "0x4023DB9")]
			[FieldOffset(Offset = "0x20")]
			private RecruitSpecialCharPortGroupView m_closure;

			// Token: 0x04023DBA RID: 146874
			[Token(Token = "0x4023DBA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023DBB RID: 146875
			[Token(Token = "0x4023DBB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023DBC RID: 146876
			[Token(Token = "0x4023DBC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
