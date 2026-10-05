using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D7B RID: 28027
	[Token(Token = "0x2006D7B")]
	public class ActCommonFavorUpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027EE6 RID: 163558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE6")]
		[Address(RVA = "0x232D020", Offset = "0x232BC20", VA = "0x18232D020")]
		public void Render(List<string> favorList, string actId)
		{
		}

		// Token: 0x06027EE7 RID: 163559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE7")]
		[Address(RVA = "0x232D690", Offset = "0x232C290", VA = "0x18232D690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027EE8 RID: 163560 RVA: 0x000D01D0 File Offset: 0x000CE3D0
		[Token(Token = "0x6027EE8")]
		[Address(RVA = "0x232D5D0", Offset = "0x232C1D0", VA = "0x18232D5D0")]
		private int _CompareFavorUpChar(ActCommonFavorUpView.ActFavorUpCharData lhs, ActCommonFavorUpView.ActFavorUpCharData rhs)
		{
			return 0;
		}

		// Token: 0x06027EE9 RID: 163561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE9")]
		[Address(RVA = "0x232D720", Offset = "0x232C320", VA = "0x18232D720")]
		public ActCommonFavorUpView()
		{
		}

		// Token: 0x04038984 RID: 231812
		[Token(Token = "0x4038984")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _newUpGroup;

		// Token: 0x04038985 RID: 231813
		[Token(Token = "0x4038985")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _upGroup;

		// Token: 0x04038986 RID: 231814
		[Token(Token = "0x4038986")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x04038987 RID: 231815
		[Token(Token = "0x4038987")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x04038988 RID: 231816
		[Token(Token = "0x4038988")]
		[FieldOffset(Offset = "0x38")]
		private List<ActCommonFavorUpView.ActFavorUpCharData> m_newUpCharList;

		// Token: 0x04038989 RID: 231817
		[Token(Token = "0x4038989")]
		[FieldOffset(Offset = "0x40")]
		private List<ActCommonFavorUpView.ActFavorUpCharData> m_upCharList;

		// Token: 0x0403898A RID: 231818
		[Token(Token = "0x403898A")]
		[FieldOffset(Offset = "0x48")]
		private ActCommonFavorUpView.ActFavorUpGroupViewAdapter m_newUpGroupAdapter;

		// Token: 0x0403898B RID: 231819
		[Token(Token = "0x403898B")]
		[FieldOffset(Offset = "0x50")]
		private ActCommonFavorUpView.ActFavorUpGroupViewAdapter m_upGroupAdapter;

		// Token: 0x0403898C RID: 231820
		[Token(Token = "0x403898C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x0403898D RID: 231821
		[Token(Token = "0x403898D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403898E RID: 231822
		[Token(Token = "0x403898E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403898F RID: 231823
		[Token(Token = "0x403898F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CompareFavorUpChar;

		// Token: 0x04038990 RID: 231824
		[Token(Token = "0x4038990")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D7C RID: 28028
		[Token(Token = "0x2006D7C")]
		private class ActFavorUpCharData
		{
			// Token: 0x06027EEA RID: 163562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027EEA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActFavorUpCharData()
			{
			}

			// Token: 0x04038991 RID: 231825
			[Token(Token = "0x4038991")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04038992 RID: 231826
			[Token(Token = "0x4038992")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x04038993 RID: 231827
			[Token(Token = "0x4038993")]
			[FieldOffset(Offset = "0x1C")]
			public RarityRank rarity;
		}

		// Token: 0x02006D7D RID: 28029
		[Token(Token = "0x2006D7D")]
		private class ActFavorUpGroupViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005E64 RID: 24164
			// (get) Token: 0x06027EEB RID: 163563 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027EEC RID: 163564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E64")]
			public List<ActCommonFavorUpView.ActFavorUpCharData> dataSet
			{
				[Token(Token = "0x6027EEB")]
				[Address(RVA = "0x23332C0", Offset = "0x2331EC0", VA = "0x1823332C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027EEC")]
				[Address(RVA = "0x2333370", Offset = "0x2331F70", VA = "0x182333370")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005E65 RID: 24165
			// (get) Token: 0x06027EED RID: 163565 RVA: 0x000D01E8 File Offset: 0x000CE3E8
			[Token(Token = "0x17005E65")]
			public override int count
			{
				[Token(Token = "0x6027EED")]
				[Address(RVA = "0x2333240", Offset = "0x2331E40", VA = "0x182333240", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027EEE RID: 163566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027EEE")]
			[Address(RVA = "0x2332E50", Offset = "0x2331A50", VA = "0x182332E50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06027EEF RID: 163567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027EEF")]
			[Address(RVA = "0x23331E0", Offset = "0x2331DE0", VA = "0x1823331E0")]
			public ActFavorUpGroupViewAdapter()
			{
			}

			// Token: 0x04038995 RID: 231829
			[Token(Token = "0x4038995")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04038996 RID: 231830
			[Token(Token = "0x4038996")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04038997 RID: 231831
			[Token(Token = "0x4038997")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038998 RID: 231832
			[Token(Token = "0x4038998")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04038999 RID: 231833
			[Token(Token = "0x4038999")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
