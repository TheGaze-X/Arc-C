using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E7D RID: 15997
	[Token(Token = "0x2003E7D")]
	public class SpecialOperatorDiagramView : DataBinder<SpecialOperatorBoardProp>
	{
		// Token: 0x06018DB9 RID: 101817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DB9")]
		[Address(RVA = "0x11941C0", Offset = "0x1192DC0", VA = "0x1811941C0", Slot = "7")]
		public override void OnValueChanged(SpecialOperatorBoardProp property)
		{
		}

		// Token: 0x06018DBA RID: 101818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DBA")]
		[Address(RVA = "0x1194750", Offset = "0x1193350", VA = "0x181194750")]
		private void _TryScrollToPos(SpecialOperatorBoardMainModel boardViewModel)
		{
		}

		// Token: 0x06018DBB RID: 101819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DBB")]
		[Address(RVA = "0x11949F0", Offset = "0x11935F0", VA = "0x1811949F0")]
		private void _UpdateSelectView(bool fastMode)
		{
		}

		// Token: 0x06018DBC RID: 101820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DBC")]
		[Address(RVA = "0x1194940", Offset = "0x1193540", VA = "0x181194940")]
		private void _UpdateMapSize(SpecialOperatorBoardLvlupModelWithDiagram lvlupModel)
		{
		}

		// Token: 0x06018DBD RID: 101821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DBD")]
		[Address(RVA = "0x1194630", Offset = "0x1193230", VA = "0x181194630")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018DBE RID: 101822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DBE")]
		[Address(RVA = "0x1194120", Offset = "0x1192D20", VA = "0x181194120")]
		public void OnBackgroudClick()
		{
		}

		// Token: 0x06018DBF RID: 101823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DBF")]
		[Address(RVA = "0x1194BE0", Offset = "0x11937E0", VA = "0x181194BE0")]
		public SpecialOperatorDiagramView()
		{
		}

		// Token: 0x0401E9BC RID: 125372
		[Token(Token = "0x401E9BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _diagramRootGO;

		// Token: 0x0401E9BD RID: 125373
		[Token(Token = "0x401E9BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _diagramContentTrans;

		// Token: 0x0401E9BE RID: 125374
		[Token(Token = "0x401E9BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _pointViewContainer;

		// Token: 0x0401E9BF RID: 125375
		[Token(Token = "0x401E9BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SpecialOperatorPointViewBase[] _pointPrefabList;

		// Token: 0x0401E9C0 RID: 125376
		[Token(Token = "0x401E9C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CustomLineGraphic _lineLockShadowGraphic;

		// Token: 0x0401E9C1 RID: 125377
		[Token(Token = "0x401E9C1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CustomLineGraphic _lineUnlockShadowGraphic;

		// Token: 0x0401E9C2 RID: 125378
		[Token(Token = "0x401E9C2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CustomLineGraphic _lineLockGraphic;

		// Token: 0x0401E9C3 RID: 125379
		[Token(Token = "0x401E9C3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CustomLineGraphic _lineUnlockGraphic;

		// Token: 0x0401E9C4 RID: 125380
		[Token(Token = "0x401E9C4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpecialOperatorDiagramSelectView _selectView;

		// Token: 0x0401E9C5 RID: 125381
		[Token(Token = "0x401E9C5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401E9C6 RID: 125382
		[Token(Token = "0x401E9C6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x0401E9C7 RID: 125383
		[Token(Token = "0x401E9C7")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _focusViewportRatio;

		// Token: 0x0401E9C8 RID: 125384
		[Token(Token = "0x401E9C8")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0401E9C9 RID: 125385
		[Token(Token = "0x401E9C9")]
		[FieldOffset(Offset = "0x80")]
		private SpecialOperatorDiagramView.PointViewPool m_pointViewPool;

		// Token: 0x0401E9CA RID: 125386
		[Token(Token = "0x401E9CA")]
		[FieldOffset(Offset = "0x88")]
		private SpecialOperatorDetailNodeType m_currNodeType;

		// Token: 0x0401E9CB RID: 125387
		[Token(Token = "0x401E9CB")]
		[FieldOffset(Offset = "0x90")]
		private SpecialOperatorBoardLvlupModelWithDiagram m_lvlupModel;

		// Token: 0x0401E9CC RID: 125388
		[Token(Token = "0x401E9CC")]
		[FieldOffset(Offset = "0x98")]
		private SpecialOperatorBoardMainModel m_boardViewModel;

		// Token: 0x0401E9CD RID: 125389
		[Token(Token = "0x401E9CD")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E9CE RID: 125390
		[Token(Token = "0x401E9CE")]
		[FieldOffset(Offset = "0xB0")]
		private int m_focusSeqNum;

		// Token: 0x0401E9CF RID: 125391
		[Token(Token = "0x401E9CF")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_focusTween;

		// Token: 0x0401E9D0 RID: 125392
		[Token(Token = "0x401E9D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E9D1 RID: 125393
		[Token(Token = "0x401E9D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryScrollToPos;

		// Token: 0x0401E9D2 RID: 125394
		[Token(Token = "0x401E9D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateSelectView;

		// Token: 0x0401E9D3 RID: 125395
		[Token(Token = "0x401E9D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateMapSize;

		// Token: 0x0401E9D4 RID: 125396
		[Token(Token = "0x401E9D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E9D5 RID: 125397
		[Token(Token = "0x401E9D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBackgroudClick;

		// Token: 0x0401E9D6 RID: 125398
		[Token(Token = "0x401E9D6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E7E RID: 15998
		[Token(Token = "0x2003E7E")]
		private class PointViewPool : GameObjectDictPool<SpecialOperatorPointViewBase>
		{
			// Token: 0x06018DC0 RID: 101824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018DC0")]
			[Address(RVA = "0x1182E20", Offset = "0x1181A20", VA = "0x181182E20")]
			public PointViewPool(SpecialOperatorDiagramView closure)
			{
			}

			// Token: 0x06018DC1 RID: 101825 RVA: 0x0009C378 File Offset: 0x0009A578
			[Token(Token = "0x6018DC1")]
			[Address(RVA = "0x1182490", Offset = "0x1181090", VA = "0x181182490", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x06018DC2 RID: 101826 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018DC2")]
			[Address(RVA = "0x1182550", Offset = "0x1181150", VA = "0x181182550", Slot = "7")]
			protected override SpecialOperatorPointViewBase GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x06018DC3 RID: 101827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018DC3")]
			[Address(RVA = "0x1182720", Offset = "0x1181320", VA = "0x181182720", Slot = "8")]
			protected override SpecialOperatorPointViewBase Instantiate(string key, SpecialOperatorPointViewBase prefab)
			{
				return null;
			}

			// Token: 0x06018DC4 RID: 101828 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018DC4")]
			[Address(RVA = "0x1182800", Offset = "0x1181400", VA = "0x181182800", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x06018DC5 RID: 101829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018DC5")]
			[Address(RVA = "0x11828B0", Offset = "0x11814B0", VA = "0x1811828B0", Slot = "10")]
			protected override void OnAllocate(string key, SpecialOperatorPointViewBase obj)
			{
			}

			// Token: 0x06018DC6 RID: 101830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018DC6")]
			[Address(RVA = "0x1182B40", Offset = "0x1181740", VA = "0x181182B40", Slot = "9")]
			protected override void Render(string key, SpecialOperatorPointViewBase obj)
			{
			}

			// Token: 0x0401E9D7 RID: 125399
			[Token(Token = "0x401E9D7")]
			[FieldOffset(Offset = "0x20")]
			private SpecialOperatorDiagramView m_closure;

			// Token: 0x0401E9D8 RID: 125400
			[Token(Token = "0x401E9D8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E9D9 RID: 125401
			[Token(Token = "0x401E9D9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0401E9DA RID: 125402
			[Token(Token = "0x401E9DA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401E9DB RID: 125403
			[Token(Token = "0x401E9DB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0401E9DC RID: 125404
			[Token(Token = "0x401E9DC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0401E9DD RID: 125405
			[Token(Token = "0x401E9DD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0401E9DE RID: 125406
			[Token(Token = "0x401E9DE")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;
		}
	}
}
