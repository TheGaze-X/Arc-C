using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	public class UIButtonUtil : IHotfixable
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x553B4C0", Offset = "0x553A0C0", VA = "0x18553B4C0")]
		public static KeyBoardVirtualButtonConfig GetVirtualButtonConfigByEnum(KeyBoardVirtualButtonEnum btnEnum)
		{
			return null;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000068B4 File Offset: 0x00004AB4
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x553BE80", Offset = "0x553AA80", VA = "0x18553BE80")]
		public static bool TryGetVirtualButtonConfig(KeyBoardVirtualButtonEnum btnEnum, out KeyBoardVirtualButtonConfig config)
		{
			return default(bool);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x553B860", Offset = "0x553A460", VA = "0x18553B860")]
		public static void RegisterUIButton(UIButton button, bool enabled)
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000068CC File Offset: 0x00004ACC
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x553B310", Offset = "0x5539F10", VA = "0x18553B310")]
		public static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			return default(RaycastResult);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x553C0C0", Offset = "0x553ACC0", VA = "0x18553C0C0")]
		public static void UnRegisterUIButton(UIButton button)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000068E4 File Offset: 0x00004AE4
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x553B570", Offset = "0x553A170", VA = "0x18553B570")]
		public static bool OnKeyBoardClick(KeyBoardVirtualButtonEnum keyEnum)
		{
			return default(bool);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000068FC File Offset: 0x00004AFC
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x553CC90", Offset = "0x553B890", VA = "0x18553CC90")]
		private static bool _OnDefaultClickBase(KeyBoardVirtualButtonEnum keyEnum)
		{
			return default(bool);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000A0")]
		public static IUIButtonLink s_buttonLink
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x553D6F0", Offset = "0x553C2F0", VA = "0x18553D6F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x553D780", Offset = "0x553C380", VA = "0x18553D780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00006914 File Offset: 0x00004B14
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x553BD90", Offset = "0x553A990", VA = "0x18553BD90")]
		public static bool TriggerKeyCode(KeyBoardVirtualButtonEnum buttonEnum)
		{
			return default(bool);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000692C File Offset: 0x00004B2C
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x553AC70", Offset = "0x5539870", VA = "0x18553AC70")]
		public static bool CheckClickAvail(UIButton uibutton)
		{
			return default(bool);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x553B600", Offset = "0x553A200", VA = "0x18553B600")]
		public static void PlayAudio(UIButton.AudioModule audio)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x553B770", Offset = "0x553A370", VA = "0x18553B770")]
		public static void RegisterClickBtn(UIButton button)
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x553BFD0", Offset = "0x553ABD0", VA = "0x18553BFD0")]
		public static void UnRegisterClickBtn(UIButton button)
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x553BF40", Offset = "0x553AB40", VA = "0x18553BF40")]
		public static void TryInterruptOtherBtnClick(UIButton button)
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x553CEB0", Offset = "0x553BAB0", VA = "0x18553CEB0")]
		private static void _TryInterruptBtnClick(UIButton button)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00006944 File Offset: 0x00004B44
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x553B1F0", Offset = "0x5539DF0", VA = "0x18553B1F0")]
		public static bool CheckIfRectTransInteractable(RectTransform anchor, Canvas rootCanvas, bool useWorldPos = true, [Optional] Func<Transform, bool> onBreak)
		{
			return default(bool);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0000695C File Offset: 0x00004B5C
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x553B0C0", Offset = "0x5539CC0", VA = "0x18553B0C0")]
		public static bool CheckIfRectTransInteractable(RectTransform anchor)
		{
			return default(bool);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00006974 File Offset: 0x00004B74
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x553ADF0", Offset = "0x55399F0", VA = "0x18553ADF0")]
		public static bool CheckIfPointInRectTransInteractable(Vector2 screenPosition, RectTransform anchor, [Optional] Func<Transform, bool> onBreak)
		{
			return default(bool);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0000698C File Offset: 0x00004B8C
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x553C240", Offset = "0x553AE40", VA = "0x18553C240")]
		private static bool _CalcInteractScreenPoint(Canvas rootCanvas, RectTransform rectTrans, bool useWorldCenter, out Vector2 output)
		{
			return default(bool);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000069A4 File Offset: 0x00004BA4
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x553CB30", Offset = "0x553B730", VA = "0x18553CB30")]
		private static bool _CheckIfUseWorldCenter(RectTransform rectTrans)
		{
			return default(bool);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000069BC File Offset: 0x00004BBC
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x553C940", Offset = "0x553B540", VA = "0x18553C940")]
		private static Vector3 _CalcRayCastPos(RectTransform rectTrans)
		{
			return default(Vector3);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000069D4 File Offset: 0x00004BD4
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x553AAA0", Offset = "0x55396A0", VA = "0x18553AAA0")]
		public static Vector3 CalcWorldCenter(RectTransform transform)
		{
			return default(Vector3);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x553D670", Offset = "0x553C270", VA = "0x18553D670")]
		public UIButtonUtil()
		{
		}

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		public const string DEFAULT_ESC_GROUP = "default";

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		public const string DEFAULT_ESC_FUNC = "defaultReturn";

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<string, KeyBoardVirtualButtonConfig> KEY_BOARD_ENUM_MAP;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<int, UIButtonUtil.UIButtonEntity> s_uibuttonRegisterList;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float s_lastKeyDownTime;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static UIButton s_lastBtnClick;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static ListDict<UIButton, KeyCode> s_keyCodeDict;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static float s_lastTickTs;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		private const float FAST_THRESHOLD = 0.23f;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static List<RaycastResult> s_raycastResultList;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly Vector3[] s_corners;

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate139 __Hotfix0_GetVirtualButtonConfigByEnum;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate140 __Hotfix0_TryGetVirtualButtonConfig;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate6 __Hotfix0_RegisterUIButton;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate141 __Hotfix0_FindFirstRaycast;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate1 __Hotfix0_UnRegisterUIButton;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate142 __Hotfix0_OnKeyBoardClick;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate142 __Hotfix0__OnDefaultClickBase;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate143 __Hotfix0_get_s_buttonLink;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate1 __Hotfix0_set_s_buttonLink;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate142 __Hotfix0_TriggerKeyCode;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckClickAvail;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_PlayAudio;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_RegisterClickBtn;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_UnRegisterClickBtn;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_TryInterruptOtherBtnClick;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate1 __Hotfix0__TryInterruptBtnClick;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate144 __Hotfix0_CheckIfRectTransInteractable;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate21 __Hotfix1_CheckIfRectTransInteractable;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate145 __Hotfix0_CheckIfPointInRectTransInteractable;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static __XLua_Gen_Delegate146 __Hotfix0__CalcInteractScreenPoint;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static __XLua_Gen_Delegate21 __Hotfix0__CheckIfUseWorldCenter;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static __XLua_Gen_Delegate97 __Hotfix0__CalcRayCastPos;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static __XLua_Gen_Delegate97 __Hotfix0_CalcWorldCenter;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0200013D RID: 317
		[Token(Token = "0x200013D")]
		private class UIButtonEntity
		{
			// Token: 0x06000792 RID: 1938 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UIButtonEntity()
			{
			}

			// Token: 0x040006AE RID: 1710
			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x040006AF RID: 1711
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIButton button;

			// Token: 0x040006B0 RID: 1712
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyBoardVirtualButtonEnum buttonEnum;

			// Token: 0x040006B1 RID: 1713
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool enabled;
		}
	}
}
