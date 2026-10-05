using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007167 RID: 29031
	[Token(Token = "0x2007167")]
	public class Act9D0FavorUpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029384 RID: 168836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029384")]
		[Address(RVA = "0x2496420", Offset = "0x2495020", VA = "0x182496420")]
		public void Render()
		{
		}

		// Token: 0x06029385 RID: 168837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029385")]
		[Address(RVA = "0x2496B20", Offset = "0x2495720", VA = "0x182496B20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029386 RID: 168838 RVA: 0x000D4C58 File Offset: 0x000D2E58
		[Token(Token = "0x6029386")]
		[Address(RVA = "0x2496A60", Offset = "0x2495660", VA = "0x182496A60")]
		private int _CompareFavorUpChar(Act9D0FavorUpView.Act9D0FavorUpCharData lhs, Act9D0FavorUpView.Act9D0FavorUpCharData rhs)
		{
			return 0;
		}

		// Token: 0x06029387 RID: 168839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029387")]
		[Address(RVA = "0x2496BB0", Offset = "0x24957B0", VA = "0x182496BB0")]
		public Act9D0FavorUpView()
		{
		}

		// Token: 0x0403ADAE RID: 241070
		[Token(Token = "0x403ADAE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _newUpGroup;

		// Token: 0x0403ADAF RID: 241071
		[Token(Token = "0x403ADAF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _upGroup;

		// Token: 0x0403ADB0 RID: 241072
		[Token(Token = "0x403ADB0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403ADB1 RID: 241073
		[Token(Token = "0x403ADB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x0403ADB2 RID: 241074
		[Token(Token = "0x403ADB2")]
		[FieldOffset(Offset = "0x38")]
		private List<Act9D0FavorUpView.Act9D0FavorUpCharData> m_newUpCharList;

		// Token: 0x0403ADB3 RID: 241075
		[Token(Token = "0x403ADB3")]
		[FieldOffset(Offset = "0x40")]
		private List<Act9D0FavorUpView.Act9D0FavorUpCharData> m_upCharList;

		// Token: 0x0403ADB4 RID: 241076
		[Token(Token = "0x403ADB4")]
		[FieldOffset(Offset = "0x48")]
		private Act9D0FavorUpView.Act9D0FavorUpGroupViewAdapter m_newUpGroupAdapter;

		// Token: 0x0403ADB5 RID: 241077
		[Token(Token = "0x403ADB5")]
		[FieldOffset(Offset = "0x50")]
		private Act9D0FavorUpView.Act9D0FavorUpGroupViewAdapter m_upGroupAdapter;

		// Token: 0x0403ADB6 RID: 241078
		[Token(Token = "0x403ADB6")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x0403ADB7 RID: 241079
		[Token(Token = "0x403ADB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ADB8 RID: 241080
		[Token(Token = "0x403ADB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403ADB9 RID: 241081
		[Token(Token = "0x403ADB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CompareFavorUpChar;

		// Token: 0x0403ADBA RID: 241082
		[Token(Token = "0x403ADBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007168 RID: 29032
		[Token(Token = "0x2007168")]
		private class Act9D0FavorUpCharData
		{
			// Token: 0x06029388 RID: 168840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029388")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act9D0FavorUpCharData()
			{
			}

			// Token: 0x0403ADBB RID: 241083
			[Token(Token = "0x403ADBB")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0403ADBC RID: 241084
			[Token(Token = "0x403ADBC")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x0403ADBD RID: 241085
			[Token(Token = "0x403ADBD")]
			[FieldOffset(Offset = "0x1C")]
			public RarityRank rarity;
		}

		// Token: 0x02007169 RID: 29033
		[Token(Token = "0x2007169")]
		private class Act9D0FavorUpGroupViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17006194 RID: 24980
			// (get) Token: 0x06029389 RID: 168841 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602938A RID: 168842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006194")]
			public List<Act9D0FavorUpView.Act9D0FavorUpCharData> dataSet
			{
				[Token(Token = "0x6029389")]
				[Address(RVA = "0x2496090", Offset = "0x2494C90", VA = "0x182496090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602938A")]
				[Address(RVA = "0x2496140", Offset = "0x2494D40", VA = "0x182496140")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17006195 RID: 24981
			// (get) Token: 0x0602938B RID: 168843 RVA: 0x000D4C70 File Offset: 0x000D2E70
			[Token(Token = "0x17006195")]
			public override int count
			{
				[Token(Token = "0x602938B")]
				[Address(RVA = "0x2496010", Offset = "0x2494C10", VA = "0x182496010", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602938C RID: 168844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602938C")]
			[Address(RVA = "0x2495C20", Offset = "0x2494820", VA = "0x182495C20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602938D RID: 168845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602938D")]
			[Address(RVA = "0x2495FB0", Offset = "0x2494BB0", VA = "0x182495FB0")]
			public Act9D0FavorUpGroupViewAdapter()
			{
			}

			// Token: 0x0403ADBF RID: 241087
			[Token(Token = "0x403ADBF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0403ADC0 RID: 241088
			[Token(Token = "0x403ADC0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0403ADC1 RID: 241089
			[Token(Token = "0x403ADC1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403ADC2 RID: 241090
			[Token(Token = "0x403ADC2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403ADC3 RID: 241091
			[Token(Token = "0x403ADC3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
