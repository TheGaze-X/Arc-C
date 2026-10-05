using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B31 RID: 31537
	[Token(Token = "0x2007B31")]
	public class Act10D5FavorUpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C26A RID: 180842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C26A")]
		[Address(RVA = "0x28064A0", Offset = "0x28050A0", VA = "0x1828064A0")]
		public void Render()
		{
		}

		// Token: 0x0602C26B RID: 180843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C26B")]
		[Address(RVA = "0x2806B20", Offset = "0x2805720", VA = "0x182806B20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C26C RID: 180844 RVA: 0x000DE420 File Offset: 0x000DC620
		[Token(Token = "0x602C26C")]
		[Address(RVA = "0x2806A60", Offset = "0x2805660", VA = "0x182806A60")]
		private int _CompareFavorUpChar(Act10D5FavorUpView.Act10D5FavorUpCharData lhs, Act10D5FavorUpView.Act10D5FavorUpCharData rhs)
		{
			return 0;
		}

		// Token: 0x0602C26D RID: 180845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C26D")]
		[Address(RVA = "0x2806BB0", Offset = "0x28057B0", VA = "0x182806BB0")]
		public Act10D5FavorUpView()
		{
		}

		// Token: 0x0403FFF9 RID: 262137
		[Token(Token = "0x403FFF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _newUpGroup;

		// Token: 0x0403FFFA RID: 262138
		[Token(Token = "0x403FFFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _upGroup;

		// Token: 0x0403FFFB RID: 262139
		[Token(Token = "0x403FFFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403FFFC RID: 262140
		[Token(Token = "0x403FFFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x0403FFFD RID: 262141
		[Token(Token = "0x403FFFD")]
		[FieldOffset(Offset = "0x38")]
		private List<Act10D5FavorUpView.Act10D5FavorUpCharData> m_newUpCharList;

		// Token: 0x0403FFFE RID: 262142
		[Token(Token = "0x403FFFE")]
		[FieldOffset(Offset = "0x40")]
		private List<Act10D5FavorUpView.Act10D5FavorUpCharData> m_upCharList;

		// Token: 0x0403FFFF RID: 262143
		[Token(Token = "0x403FFFF")]
		[FieldOffset(Offset = "0x48")]
		private Act10D5FavorUpView.Act10D5FavorUpGroupViewAdapter m_newUpGroupAdapter;

		// Token: 0x04040000 RID: 262144
		[Token(Token = "0x4040000")]
		[FieldOffset(Offset = "0x50")]
		private Act10D5FavorUpView.Act10D5FavorUpGroupViewAdapter m_upGroupAdapter;

		// Token: 0x04040001 RID: 262145
		[Token(Token = "0x4040001")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04040002 RID: 262146
		[Token(Token = "0x4040002")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04040003 RID: 262147
		[Token(Token = "0x4040003")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04040004 RID: 262148
		[Token(Token = "0x4040004")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CompareFavorUpChar;

		// Token: 0x04040005 RID: 262149
		[Token(Token = "0x4040005")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007B32 RID: 31538
		[Token(Token = "0x2007B32")]
		private class Act10D5FavorUpCharData
		{
			// Token: 0x0602C26E RID: 180846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C26E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act10D5FavorUpCharData()
			{
			}

			// Token: 0x04040006 RID: 262150
			[Token(Token = "0x4040006")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04040007 RID: 262151
			[Token(Token = "0x4040007")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x04040008 RID: 262152
			[Token(Token = "0x4040008")]
			[FieldOffset(Offset = "0x1C")]
			public RarityRank rarity;
		}

		// Token: 0x02007B33 RID: 31539
		[Token(Token = "0x2007B33")]
		private class Act10D5FavorUpGroupViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700676B RID: 26475
			// (get) Token: 0x0602C26F RID: 180847 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602C270 RID: 180848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700676B")]
			public List<Act10D5FavorUpView.Act10D5FavorUpCharData> dataSet
			{
				[Token(Token = "0x602C26F")]
				[Address(RVA = "0x2805B70", Offset = "0x2804770", VA = "0x182805B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602C270")]
				[Address(RVA = "0x2805C20", Offset = "0x2804820", VA = "0x182805C20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700676C RID: 26476
			// (get) Token: 0x0602C271 RID: 180849 RVA: 0x000DE438 File Offset: 0x000DC638
			[Token(Token = "0x1700676C")]
			public override int count
			{
				[Token(Token = "0x602C271")]
				[Address(RVA = "0x2805AF0", Offset = "0x28046F0", VA = "0x182805AF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602C272 RID: 180850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C272")]
			[Address(RVA = "0x28058D0", Offset = "0x28044D0", VA = "0x1828058D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602C273 RID: 180851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C273")]
			[Address(RVA = "0x2805A90", Offset = "0x2804690", VA = "0x182805A90")]
			public Act10D5FavorUpGroupViewAdapter()
			{
			}

			// Token: 0x0404000A RID: 262154
			[Token(Token = "0x404000A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0404000B RID: 262155
			[Token(Token = "0x404000B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0404000C RID: 262156
			[Token(Token = "0x404000C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0404000D RID: 262157
			[Token(Token = "0x404000D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0404000E RID: 262158
			[Token(Token = "0x404000E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
