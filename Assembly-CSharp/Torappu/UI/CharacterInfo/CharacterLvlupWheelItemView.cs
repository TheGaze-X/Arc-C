using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F6A RID: 24426
	[Token(Token = "0x2005F6A")]
	public class CharacterLvlupWheelItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060235CB RID: 144843 RVA: 0x000C0A38 File Offset: 0x000BEC38
		[Token(Token = "0x60235CB")]
		[Address(RVA = "0x1E0D830", Offset = "0x1E0C430", VA = "0x181E0D830")]
		public float GetPreferSize(float pageDistance)
		{
			return 0f;
		}

		// Token: 0x060235CC RID: 144844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235CC")]
		[Address(RVA = "0x1E0D8F0", Offset = "0x1E0C4F0", VA = "0x181E0D8F0")]
		private void Render(CharacterLvlupWheelItemView.Param param, bool isSelected)
		{
		}

		// Token: 0x060235CD RID: 144845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235CD")]
		[Address(RVA = "0x1E0DEA0", Offset = "0x1E0CAA0", VA = "0x181E0DEA0")]
		private void _UdpateTextColor(CharacterLvlupWheelItemView.ColorParam param, CharacterLvlupWheelItemView.StyleStatus status)
		{
		}

		// Token: 0x060235CE RID: 144846 RVA: 0x000C0A50 File Offset: 0x000BEC50
		[Token(Token = "0x60235CE")]
		[Address(RVA = "0x1E0DDB0", Offset = "0x1E0C9B0", VA = "0x181E0DDB0")]
		private static CharacterLvlupWheelItemView.StyleStatus _GetStyleStatus(bool isAttainable, bool isSelected)
		{
			return CharacterLvlupWheelItemView.StyleStatus.NONE;
		}

		// Token: 0x060235CF RID: 144847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235CF")]
		[Address(RVA = "0x1E0D7C0", Offset = "0x1E0C3C0", VA = "0x181E0D7C0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060235D0 RID: 144848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235D0")]
		[Address(RVA = "0x1E0E0D0", Offset = "0x1E0CCD0", VA = "0x181E0E0D0")]
		public CharacterLvlupWheelItemView()
		{
		}

		// Token: 0x04030D43 RID: 200003
		[Token(Token = "0x4030D43")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtNum;

		// Token: 0x04030D44 RID: 200004
		[Token(Token = "0x4030D44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtNumShadow;

		// Token: 0x04030D45 RID: 200005
		[Token(Token = "0x4030D45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("lvlMax")]
		private Graphic _imgMax;

		// Token: 0x04030D46 RID: 200006
		[Token(Token = "0x4030D46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("lvlMax")]
		private Color _maxEnabledColor;

		// Token: 0x04030D47 RID: 200007
		[Token(Token = "0x4030D47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("lvlMax")]
		private Color _maxDisabledColor;

		// Token: 0x04030D48 RID: 200008
		[Token(Token = "0x4030D48")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _sizeUnselect;

		// Token: 0x04030D49 RID: 200009
		[Token(Token = "0x4030D49")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _sizeSelected;

		// Token: 0x04030D4A RID: 200010
		[Token(Token = "0x4030D4A")]
		[FieldOffset(Offset = "0x58")]
		private int m_curNum;

		// Token: 0x04030D4B RID: 200011
		[Token(Token = "0x4030D4B")]
		[FieldOffset(Offset = "0x5C")]
		private int m_pageIndex;

		// Token: 0x04030D4C RID: 200012
		[Token(Token = "0x4030D4C")]
		[FieldOffset(Offset = "0x60")]
		private CharacterLvlupWheelItemView.StyleStatus m_styleStatus;

		// Token: 0x04030D4D RID: 200013
		[Token(Token = "0x4030D4D")]
		[FieldOffset(Offset = "0x68")]
		private Action<int> m_onItemClicked;

		// Token: 0x04030D4E RID: 200014
		[Token(Token = "0x4030D4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x04030D4F RID: 200015
		[Token(Token = "0x4030D4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030D50 RID: 200016
		[Token(Token = "0x4030D50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UdpateTextColor;

		// Token: 0x04030D51 RID: 200017
		[Token(Token = "0x4030D51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetStyleStatus;

		// Token: 0x04030D52 RID: 200018
		[Token(Token = "0x4030D52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04030D53 RID: 200019
		[Token(Token = "0x4030D53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F6B RID: 24427
		[Token(Token = "0x2005F6B")]
		public struct ColorParam
		{
			// Token: 0x04030D54 RID: 200020
			[Token(Token = "0x4030D54")]
			[FieldOffset(Offset = "0x0")]
			public Color attainableNumColor;

			// Token: 0x04030D55 RID: 200021
			[Token(Token = "0x4030D55")]
			[FieldOffset(Offset = "0x10")]
			public Color attainableShadowColor;

			// Token: 0x04030D56 RID: 200022
			[Token(Token = "0x4030D56")]
			[FieldOffset(Offset = "0x20")]
			public Color attainableNumSelectedColor;

			// Token: 0x04030D57 RID: 200023
			[Token(Token = "0x4030D57")]
			[FieldOffset(Offset = "0x30")]
			public Color attainableShadowSelectedColor;

			// Token: 0x04030D58 RID: 200024
			[Token(Token = "0x4030D58")]
			[FieldOffset(Offset = "0x40")]
			public Color unattainableNumColor;

			// Token: 0x04030D59 RID: 200025
			[Token(Token = "0x4030D59")]
			[FieldOffset(Offset = "0x50")]
			public Color unattainableShadowColor;

			// Token: 0x04030D5A RID: 200026
			[Token(Token = "0x4030D5A")]
			[FieldOffset(Offset = "0x60")]
			public Color unattainableNumSelectedColor;

			// Token: 0x04030D5B RID: 200027
			[Token(Token = "0x4030D5B")]
			[FieldOffset(Offset = "0x70")]
			public Color unattainableShadowSelectedColor;
		}

		// Token: 0x02005F6C RID: 24428
		[Token(Token = "0x2005F6C")]
		public struct Param
		{
			// Token: 0x04030D5C RID: 200028
			[Token(Token = "0x4030D5C")]
			[FieldOffset(Offset = "0x0")]
			public CharacterLvlupWheelItemView prefab;

			// Token: 0x04030D5D RID: 200029
			[Token(Token = "0x4030D5D")]
			[FieldOffset(Offset = "0x8")]
			public CharacterLvlupWheelItemViewModel itemModel;

			// Token: 0x04030D5E RID: 200030
			[Token(Token = "0x4030D5E")]
			[FieldOffset(Offset = "0x10")]
			public CharacterLvlupWheelItemView.ColorParam colorParam;

			// Token: 0x04030D5F RID: 200031
			[Token(Token = "0x4030D5F")]
			[FieldOffset(Offset = "0x90")]
			public int pageIndex;

			// Token: 0x04030D60 RID: 200032
			[Token(Token = "0x4030D60")]
			[FieldOffset(Offset = "0x98")]
			public Action<int> onItemClicked;
		}

		// Token: 0x02005F6D RID: 24429
		[Token(Token = "0x2005F6D")]
		private enum StyleStatus
		{
			// Token: 0x04030D62 RID: 200034
			[Token(Token = "0x4030D62")]
			NONE,
			// Token: 0x04030D63 RID: 200035
			[Token(Token = "0x4030D63")]
			ATTAIN_SELECT,
			// Token: 0x04030D64 RID: 200036
			[Token(Token = "0x4030D64")]
			ATTAIN_UNSELECT,
			// Token: 0x04030D65 RID: 200037
			[Token(Token = "0x4030D65")]
			UNATTAIN_SELECT,
			// Token: 0x04030D66 RID: 200038
			[Token(Token = "0x4030D66")]
			UNATTAIN_UNSELECT
		}

		// Token: 0x02005F6E RID: 24430
		[Token(Token = "0x2005F6E")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<CharacterLvlupWheelItemView>
		{
			// Token: 0x060235D1 RID: 144849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235D1")]
			[Address(RVA = "0x1E127F0", Offset = "0x1E113F0", VA = "0x181E127F0")]
			public VirtualView(CharacterLvlupWheelItemView.Param param)
			{
			}

			// Token: 0x060235D2 RID: 144850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235D2")]
			[Address(RVA = "0x1E12570", Offset = "0x1E11170", VA = "0x181E12570")]
			public void UpdateFocusPage(float pageIndex)
			{
			}

			// Token: 0x060235D3 RID: 144851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235D3")]
			[Address(RVA = "0x1E12380", Offset = "0x1E10F80", VA = "0x181E12380", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x060235D4 RID: 144852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235D4")]
			[Address(RVA = "0x1E12510", Offset = "0x1E11110", VA = "0x181E12510", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x060235D5 RID: 144853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235D5")]
			[Address(RVA = "0x1E12180", Offset = "0x1E10D80", VA = "0x181E12180", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060235D6 RID: 144854 RVA: 0x000C0A68 File Offset: 0x000BEC68
			[Token(Token = "0x60235D6")]
			[Address(RVA = "0x1E121F0", Offset = "0x1E10DF0", VA = "0x181E121F0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060235D7 RID: 144855 RVA: 0x000C0A80 File Offset: 0x000BEC80
			[Token(Token = "0x60235D7")]
			[Address(RVA = "0x1E12770", Offset = "0x1E11370", VA = "0x181E12770")]
			private bool _CheckIfSelected()
			{
				return default(bool);
			}

			// Token: 0x04030D67 RID: 200039
			[Token(Token = "0x4030D67")]
			[FieldOffset(Offset = "0x20")]
			private CharacterLvlupWheelItemView.Param m_param;

			// Token: 0x04030D68 RID: 200040
			[Token(Token = "0x4030D68")]
			[FieldOffset(Offset = "0xC0")]
			private float m_curFocusPage;

			// Token: 0x04030D69 RID: 200041
			[Token(Token = "0x4030D69")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030D6A RID: 200042
			[Token(Token = "0x4030D6A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateFocusPage;

			// Token: 0x04030D6B RID: 200043
			[Token(Token = "0x4030D6B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04030D6C RID: 200044
			[Token(Token = "0x4030D6C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04030D6D RID: 200045
			[Token(Token = "0x4030D6D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04030D6E RID: 200046
			[Token(Token = "0x4030D6E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04030D6F RID: 200047
			[Token(Token = "0x4030D6F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__CheckIfSelected;
		}
	}
}
