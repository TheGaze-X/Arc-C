using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E79 RID: 15993
	[Token(Token = "0x2003E79")]
	public class SpecialOperatorBoardLvlupEquipDetailView : SpecialOperatorBoardLvlupDetailView<SpecialOperatorBoardUniEquipNode>
	{
		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x06018DAB RID: 101803 RVA: 0x0009C348 File Offset: 0x0009A548
		[Token(Token = "0x17003B53")]
		public override SpecialOperatorDetailNodeType nodeType
		{
			[Token(Token = "0x6018DAB")]
			[Address(RVA = "0x11899D0", Offset = "0x11885D0", VA = "0x1811899D0", Slot = "4")]
			get
			{
				return SpecialOperatorDetailNodeType.NONE;
			}
		}

		// Token: 0x06018DAC RID: 101804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DAC")]
		[Address(RVA = "0x1189670", Offset = "0x1188270", VA = "0x181189670", Slot = "5")]
		public override void SetViewShow(bool isShow)
		{
		}

		// Token: 0x06018DAD RID: 101805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DAD")]
		[Address(RVA = "0x11896F0", Offset = "0x11882F0", VA = "0x1811896F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018DAE RID: 101806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DAE")]
		[Address(RVA = "0x11890C0", Offset = "0x1187CC0", VA = "0x1811890C0", Slot = "7")]
		public override void Render(SpecialOperatorBoardUniEquipNode viewModel, bool fastMode)
		{
		}

		// Token: 0x06018DAF RID: 101807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DAF")]
		[Address(RVA = "0x1189960", Offset = "0x1188560", VA = "0x181189960")]
		public SpecialOperatorBoardLvlupEquipDetailView()
		{
		}

		// Token: 0x0401E98A RID: 125322
		[Token(Token = "0x401E98A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0401E98B RID: 125323
		[Token(Token = "0x401E98B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonEquipTypeIcon _iconPrefab;

		// Token: 0x0401E98C RID: 125324
		[Token(Token = "0x401E98C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _iconContainer;

		// Token: 0x0401E98D RID: 125325
		[Token(Token = "0x401E98D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelRightLevel;

		// Token: 0x0401E98E RID: 125326
		[Token(Token = "0x401E98E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _levelFrom;

		// Token: 0x0401E98F RID: 125327
		[Token(Token = "0x401E98F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _levelTo;

		// Token: 0x0401E990 RID: 125328
		[Token(Token = "0x401E990")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401E991 RID: 125329
		[Token(Token = "0x401E991")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _equipDetail;

		// Token: 0x0401E992 RID: 125330
		[Token(Token = "0x401E992")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelActivePre;

		// Token: 0x0401E993 RID: 125331
		[Token(Token = "0x401E993")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelCanActive;

		// Token: 0x0401E994 RID: 125332
		[Token(Token = "0x401E994")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelActivated;

		// Token: 0x0401E995 RID: 125333
		[Token(Token = "0x401E995")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelTaskFinished;

		// Token: 0x0401E996 RID: 125334
		[Token(Token = "0x401E996")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _taskDesc;

		// Token: 0x0401E997 RID: 125335
		[Token(Token = "0x401E997")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _unfinishedTaskColor;

		// Token: 0x0401E998 RID: 125336
		[Token(Token = "0x401E998")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _finishedTaskColor;

		// Token: 0x0401E999 RID: 125337
		[Token(Token = "0x401E999")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ScrollRect _contentScrollRect;

		// Token: 0x0401E99A RID: 125338
		[Token(Token = "0x401E99A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ScrollRect _taskScrollRect;

		// Token: 0x0401E99B RID: 125339
		[Token(Token = "0x401E99B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0401E99C RID: 125340
		[Token(Token = "0x401E99C")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0401E99D RID: 125341
		[Token(Token = "0x401E99D")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x0401E99E RID: 125342
		[Token(Token = "0x401E99E")]
		[FieldOffset(Offset = "0xE8")]
		private SpecialOperatorBoardLvlupEquipDetailView.Adapter m_adapter;

		// Token: 0x0401E99F RID: 125343
		[Token(Token = "0x401E99F")]
		[FieldOffset(Offset = "0xF0")]
		private SpecialOperatorBoardUniEquipNode m_cachedModel;

		// Token: 0x0401E9A0 RID: 125344
		[Token(Token = "0x401E9A0")]
		[FieldOffset(Offset = "0xF8")]
		private UICommonEquipTypeIcon m_equipIcon;

		// Token: 0x0401E9A1 RID: 125345
		[Token(Token = "0x401E9A1")]
		[FieldOffset(Offset = "0x100")]
		private string m_cachedNodeId;

		// Token: 0x0401E9A2 RID: 125346
		[Token(Token = "0x401E9A2")]
		[FieldOffset(Offset = "0x108")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0401E9A3 RID: 125347
		[Token(Token = "0x401E9A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401E9A4 RID: 125348
		[Token(Token = "0x401E9A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetViewShow;

		// Token: 0x0401E9A5 RID: 125349
		[Token(Token = "0x401E9A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E9A6 RID: 125350
		[Token(Token = "0x401E9A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E9A7 RID: 125351
		[Token(Token = "0x401E9A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E7A RID: 15994
		[Token(Token = "0x2003E7A")]
		private enum State
		{
			// Token: 0x0401E9A9 RID: 125353
			[Token(Token = "0x401E9A9")]
			ACTIVATE_PRE,
			// Token: 0x0401E9AA RID: 125354
			[Token(Token = "0x401E9AA")]
			CAN_ACTIVATE,
			// Token: 0x0401E9AB RID: 125355
			[Token(Token = "0x401E9AB")]
			ACTIVATED
		}

		// Token: 0x02003E7B RID: 15995
		[Token(Token = "0x2003E7B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06018DB0 RID: 101808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018DB0")]
			[Address(RVA = "0x1181990", Offset = "0x1180590", VA = "0x181181990")]
			public Adapter(SpecialOperatorBoardLvlupEquipDetailView closure)
			{
			}

			// Token: 0x17003B54 RID: 15188
			// (get) Token: 0x06018DB1 RID: 101809 RVA: 0x0009C360 File Offset: 0x0009A560
			[Token(Token = "0x17003B54")]
			public override int count
			{
				[Token(Token = "0x6018DB1")]
				[Address(RVA = "0x1181C30", Offset = "0x1180830", VA = "0x181181C30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018DB2 RID: 101810 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018DB2")]
			[Address(RVA = "0x11810C0", Offset = "0x117FCC0", VA = "0x1811810C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E9AC RID: 125356
			[Token(Token = "0x401E9AC")]
			[FieldOffset(Offset = "0x20")]
			private SpecialOperatorBoardLvlupEquipDetailView m_closure;

			// Token: 0x0401E9AD RID: 125357
			[Token(Token = "0x401E9AD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E9AE RID: 125358
			[Token(Token = "0x401E9AE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E9AF RID: 125359
			[Token(Token = "0x401E9AF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
