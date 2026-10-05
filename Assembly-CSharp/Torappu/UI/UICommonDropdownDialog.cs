using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039EB RID: 14827
	[Token(Token = "0x20039EB")]
	public abstract class UICommonDropdownDialog : UICompDialog<UICommonDropdownDialog.Input>, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x06017698 RID: 95896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017698")]
		[Address(RVA = "0xFC0C90", Offset = "0xFBF890", VA = "0x180FC0C90", Slot = "9")]
		protected sealed override void OnInit()
		{
		}

		// Token: 0x06017699 RID: 95897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017699")]
		[Address(RVA = "0xFC0EF0", Offset = "0xFBFAF0", VA = "0x180FC0EF0", Slot = "18")]
		protected sealed override void OnRender(UICommonDropdownDialog.Input input)
		{
		}

		// Token: 0x0601769A RID: 95898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601769A")]
		[Address(RVA = "0xFC0B30", Offset = "0xFBF730", VA = "0x180FC0B30")]
		private void LateUpdate()
		{
		}

		// Token: 0x0601769B RID: 95899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601769B")]
		[Address(RVA = "0xFC0D30", Offset = "0xFBF930", VA = "0x180FC0D30", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601769C RID: 95900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601769C")]
		[Address(RVA = "0xFC1740", Offset = "0xFC0340", VA = "0x180FC1740")]
		private void _EventOnItemClicked(int index)
		{
		}

		// Token: 0x0601769D RID: 95901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601769D")]
		[Address(RVA = "0xFC0990", Offset = "0xFBF590", VA = "0x180FC0990")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601769E RID: 95902 RVA: 0x00096588 File Offset: 0x00094788
		[Token(Token = "0x601769E")]
		[Address(RVA = "0xFC0A60", Offset = "0xFBF660", VA = "0x180FC0A60", Slot = "20")]
		protected virtual UICommonDropdownDialog.DropdownExpansionType GetExpansionType()
		{
			return UICommonDropdownDialog.DropdownExpansionType.FIT;
		}

		// Token: 0x0601769F RID: 95903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601769F")]
		[Address(RVA = "0xFC0C20", Offset = "0xFBF820", VA = "0x180FC0C20", Slot = "21")]
		protected virtual void OnDialogInit()
		{
		}

		// Token: 0x060176A0 RID: 95904
		[Token(Token = "0x60176A0")]
		protected abstract void OnDialogRender(UICommonDropdownDialog.InnerInput input);

		// Token: 0x060176A1 RID: 95905 RVA: 0x000965A0 File Offset: 0x000947A0
		[Token(Token = "0x60176A1")]
		[Address(RVA = "0xFC12B0", Offset = "0xFBFEB0", VA = "0x180FC12B0")]
		protected bool _CheckIfTargetInvalid()
		{
			return default(bool);
		}

		// Token: 0x060176A2 RID: 95906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176A2")]
		[Address(RVA = "0xFC1860", Offset = "0xFC0460", VA = "0x180FC1860")]
		private void _SetDropdownRect(UICommonDropdownDialog.InnerInput input)
		{
		}

		// Token: 0x060176A3 RID: 95907 RVA: 0x000965B8 File Offset: 0x000947B8
		[Token(Token = "0x60176A3")]
		[Address(RVA = "0xFC15D0", Offset = "0xFC01D0", VA = "0x180FC15D0")]
		private static bool _CheckIfTargetPosChanged(Vector2 initPos, Vector2 targetPos)
		{
			return default(bool);
		}

		// Token: 0x060176A4 RID: 95908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176A4")]
		[Address(RVA = "0xFC1F20", Offset = "0xFC0B20", VA = "0x180FC1F20")]
		protected UICommonDropdownDialog()
		{
		}

		// Token: 0x060176A6 RID: 95910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176A6")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0401C474 RID: 115828
		[Token(Token = "0x401C474")]
		[NonSerialized]
		public const int ON_ITEM_CLICKED = 0;

		// Token: 0x0401C475 RID: 115829
		[Token(Token = "0x401C475")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<string, UICommonDropdownDialog.DropdownDisplayInfo> s_displayInfoDict;

		// Token: 0x0401C476 RID: 115830
		[Token(Token = "0x401C476")]
		protected const float SCREEN_CENTER_PREFER_DELTA = 35f;

		// Token: 0x0401C477 RID: 115831
		[Token(Token = "0x401C477")]
		private const float POS_CHANGE_DIS = 0.5f;

		// Token: 0x0401C478 RID: 115832
		[Token(Token = "0x401C478")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected RectTransform _dropDownRect;

		// Token: 0x0401C479 RID: 115833
		[Token(Token = "0x401C479")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PassThroughPointer _passThrough;

		// Token: 0x0401C47A RID: 115834
		[Token(Token = "0x401C47A")]
		[FieldOffset(Offset = "0x80")]
		private TargetPosCalculator m_targetPosCalc;

		// Token: 0x0401C47B RID: 115835
		[Token(Token = "0x401C47B")]
		[FieldOffset(Offset = "0x88")]
		private Vector2 m_itemInitPos;

		// Token: 0x0401C47C RID: 115836
		[Token(Token = "0x401C47C")]
		[FieldOffset(Offset = "0x90")]
		protected List<ICommonDropdownModel> modelList;

		// Token: 0x0401C47D RID: 115837
		[Token(Token = "0x401C47D")]
		[FieldOffset(Offset = "0x98")]
		protected GameObject cachedTarget;

		// Token: 0x0401C47E RID: 115838
		[Token(Token = "0x401C47E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C47F RID: 115839
		[Token(Token = "0x401C47F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401C480 RID: 115840
		[Token(Token = "0x401C480")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0401C481 RID: 115841
		[Token(Token = "0x401C481")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401C482 RID: 115842
		[Token(Token = "0x401C482")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x0401C483 RID: 115843
		[Token(Token = "0x401C483")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0401C484 RID: 115844
		[Token(Token = "0x401C484")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetExpansionType;

		// Token: 0x0401C485 RID: 115845
		[Token(Token = "0x401C485")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDialogInit;

		// Token: 0x0401C486 RID: 115846
		[Token(Token = "0x401C486")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIfTargetInvalid;

		// Token: 0x0401C487 RID: 115847
		[Token(Token = "0x401C487")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetDropdownRect;

		// Token: 0x0401C488 RID: 115848
		[Token(Token = "0x401C488")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckIfTargetPosChanged;

		// Token: 0x0401C489 RID: 115849
		[Token(Token = "0x401C489")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039EC RID: 14828
		[Token(Token = "0x20039EC")]
		public enum DropdownDisplayType
		{
			// Token: 0x0401C48B RID: 115851
			[Token(Token = "0x401C48B")]
			NORMAL
		}

		// Token: 0x020039ED RID: 14829
		[Token(Token = "0x20039ED")]
		public class Input
		{
			// Token: 0x060176A7 RID: 95911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60176A7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0401C48C RID: 115852
			[Token(Token = "0x401C48C")]
			[FieldOffset(Offset = "0x10")]
			public GameObject targetGameObject;

			// Token: 0x0401C48D RID: 115853
			[Token(Token = "0x401C48D")]
			[FieldOffset(Offset = "0x18")]
			public List<ICommonDropdownModel> modelList;

			// Token: 0x0401C48E RID: 115854
			[Token(Token = "0x401C48E")]
			[FieldOffset(Offset = "0x20")]
			public int focusIndex;

			// Token: 0x0401C48F RID: 115855
			[Token(Token = "0x401C48F")]
			[FieldOffset(Offset = "0x24")]
			public UICommonDropdownDialog.DropdownDisplayType displayType;

			// Token: 0x0401C490 RID: 115856
			[Token(Token = "0x401C490")]
			[FieldOffset(Offset = "0x28")]
			public bool enablePassThrough;
		}

		// Token: 0x020039EE RID: 14830
		[Token(Token = "0x20039EE")]
		protected class InnerInput
		{
			// Token: 0x060176A8 RID: 95912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60176A8")]
			[Address(RVA = "0xFB1690", Offset = "0xFB0290", VA = "0x180FB1690")]
			public InnerInput(UICommonDropdownDialog.Input input)
			{
			}

			// Token: 0x0401C491 RID: 115857
			[Token(Token = "0x401C491")]
			[FieldOffset(Offset = "0x10")]
			public int focusIndex;

			// Token: 0x0401C492 RID: 115858
			[Token(Token = "0x401C492")]
			[FieldOffset(Offset = "0x18")]
			public UICommonDropdownDialog.DropdownDisplayInfo displayInfo;
		}

		// Token: 0x020039EF RID: 14831
		[Token(Token = "0x20039EF")]
		protected class DropdownDisplayInfo
		{
			// Token: 0x060176A9 RID: 95913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60176A9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DropdownDisplayInfo()
			{
			}

			// Token: 0x0401C493 RID: 115859
			[Token(Token = "0x401C493")]
			[FieldOffset(Offset = "0x10")]
			public int itemHeight;

			// Token: 0x0401C494 RID: 115860
			[Token(Token = "0x401C494")]
			[FieldOffset(Offset = "0x14")]
			public int totalHeight;
		}

		// Token: 0x020039F0 RID: 14832
		[Token(Token = "0x20039F0")]
		protected enum DropdownExpansionType
		{
			// Token: 0x0401C496 RID: 115862
			[Token(Token = "0x401C496")]
			FIT,
			// Token: 0x0401C497 RID: 115863
			[Token(Token = "0x401C497")]
			CUSTOM
		}
	}
}
