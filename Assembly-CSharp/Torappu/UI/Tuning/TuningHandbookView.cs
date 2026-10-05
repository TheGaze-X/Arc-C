using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C92 RID: 15506
	[Token(Token = "0x2003C92")]
	public class TuningHandbookView : DataBinder<TuningHandbookProperty>, IHotfixable
	{
		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0601836D RID: 99181 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601836E RID: 99182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170039CF")]
		public Action<string> onEmotionClickedAction
		{
			[Token(Token = "0x601836D")]
			[Address(RVA = "0x10B7580", Offset = "0x10B6180", VA = "0x1810B7580")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601836E")]
			[Address(RVA = "0x10B75E0", Offset = "0x10B61E0", VA = "0x1810B75E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601836F RID: 99183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601836F")]
		[Address(RVA = "0x10B7090", Offset = "0x10B5C90", VA = "0x1810B7090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018370 RID: 99184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018370")]
		[Address(RVA = "0x10B7270", Offset = "0x10B5E70", VA = "0x1810B7270")]
		private void _UpdateMusicMessage()
		{
		}

		// Token: 0x06018371 RID: 99185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018371")]
		[Address(RVA = "0x10B6F40", Offset = "0x10B5B40", VA = "0x1810B6F40", Slot = "7")]
		public override void OnValueChanged(TuningHandbookProperty property)
		{
		}

		// Token: 0x06018372 RID: 99186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018372")]
		[Address(RVA = "0x10B7510", Offset = "0x10B6110", VA = "0x1810B7510")]
		public TuningHandbookView()
		{
		}

		// Token: 0x0401D7E3 RID: 120803
		[Token(Token = "0x401D7E3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401D7E4 RID: 120804
		[Token(Token = "0x401D7E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textAlias;

		// Token: 0x0401D7E5 RID: 120805
		[Token(Token = "0x401D7E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDes;

		// Token: 0x0401D7E6 RID: 120806
		[Token(Token = "0x401D7E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgMusic;

		// Token: 0x0401D7E7 RID: 120807
		[Token(Token = "0x401D7E7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objNormalMsg;

		// Token: 0x0401D7E8 RID: 120808
		[Token(Token = "0x401D7E8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objSpMsg;

		// Token: 0x0401D7E9 RID: 120809
		[Token(Token = "0x401D7E9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgSpMusic;

		// Token: 0x0401D7EA RID: 120810
		[Token(Token = "0x401D7EA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textSpName;

		// Token: 0x0401D7EB RID: 120811
		[Token(Token = "0x401D7EB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textSpAlias;

		// Token: 0x0401D7EC RID: 120812
		[Token(Token = "0x401D7EC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textSpDes;

		// Token: 0x0401D7ED RID: 120813
		[Token(Token = "0x401D7ED")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _layoutContentEmotionDetail;

		// Token: 0x0401D7EE RID: 120814
		[Token(Token = "0x401D7EE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _layoutContentFormulaDetail;

		// Token: 0x0401D7EF RID: 120815
		[Token(Token = "0x401D7EF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0401D7F0 RID: 120816
		[Token(Token = "0x401D7F0")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D7F1 RID: 120817
		[Token(Token = "0x401D7F1")]
		[FieldOffset(Offset = "0x98")]
		private TuningHandbookViewModel m_model;

		// Token: 0x0401D7F2 RID: 120818
		[Token(Token = "0x401D7F2")]
		[FieldOffset(Offset = "0xA0")]
		private TuningHandbookView.EmotionDetailAdapter m_emotionDetailAdapter;

		// Token: 0x0401D7F3 RID: 120819
		[Token(Token = "0x401D7F3")]
		[FieldOffset(Offset = "0xA8")]
		private TuningHandbookView.FormulaDetailAdapter m_formulaDetailAdapter;

		// Token: 0x0401D7F5 RID: 120821
		[Token(Token = "0x401D7F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEmotionClickedAction;

		// Token: 0x0401D7F6 RID: 120822
		[Token(Token = "0x401D7F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEmotionClickedAction;

		// Token: 0x0401D7F7 RID: 120823
		[Token(Token = "0x401D7F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D7F8 RID: 120824
		[Token(Token = "0x401D7F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateMusicMessage;

		// Token: 0x0401D7F9 RID: 120825
		[Token(Token = "0x401D7F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D7FA RID: 120826
		[Token(Token = "0x401D7FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C93 RID: 15507
		[Token(Token = "0x2003C93")]
		private class FormulaDetailAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018373 RID: 99187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018373")]
			[Address(RVA = "0x10A4DE0", Offset = "0x10A39E0", VA = "0x1810A4DE0")]
			public FormulaDetailAdapter(TuningHandbookView closure)
			{
			}

			// Token: 0x170039D0 RID: 14800
			// (get) Token: 0x06018374 RID: 99188 RVA: 0x00099B10 File Offset: 0x00097D10
			[Token(Token = "0x170039D0")]
			public override int count
			{
				[Token(Token = "0x6018374")]
				[Address(RVA = "0x10A4E60", Offset = "0x10A3A60", VA = "0x1810A4E60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018375 RID: 99189 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018375")]
			[Address(RVA = "0x10A4C10", Offset = "0x10A3810", VA = "0x1810A4C10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D7FB RID: 120827
			[Token(Token = "0x401D7FB")]
			[FieldOffset(Offset = "0x20")]
			private TuningHandbookView m_closure;

			// Token: 0x0401D7FC RID: 120828
			[Token(Token = "0x401D7FC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D7FD RID: 120829
			[Token(Token = "0x401D7FD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D7FE RID: 120830
			[Token(Token = "0x401D7FE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02003C94 RID: 15508
		[Token(Token = "0x2003C94")]
		private class EmotionDetailAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018376 RID: 99190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018376")]
			[Address(RVA = "0x10A4580", Offset = "0x10A3180", VA = "0x1810A4580")]
			public EmotionDetailAdapter(TuningHandbookView closure)
			{
			}

			// Token: 0x170039D1 RID: 14801
			// (get) Token: 0x06018377 RID: 99191 RVA: 0x00099B28 File Offset: 0x00097D28
			[Token(Token = "0x170039D1")]
			public override int count
			{
				[Token(Token = "0x6018377")]
				[Address(RVA = "0x10A4600", Offset = "0x10A3200", VA = "0x1810A4600", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018378 RID: 99192 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018378")]
			[Address(RVA = "0x10A43A0", Offset = "0x10A2FA0", VA = "0x1810A43A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D7FF RID: 120831
			[Token(Token = "0x401D7FF")]
			[FieldOffset(Offset = "0x20")]
			private TuningHandbookView m_closure;

			// Token: 0x0401D800 RID: 120832
			[Token(Token = "0x401D800")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D801 RID: 120833
			[Token(Token = "0x401D801")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D802 RID: 120834
			[Token(Token = "0x401D802")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
