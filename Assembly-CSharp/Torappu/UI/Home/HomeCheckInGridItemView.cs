using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004BE3 RID: 19427
	[Token(Token = "0x2004BE3")]
	public class HomeCheckInGridItemView : MonoBehaviour
	{
		// Token: 0x0601D328 RID: 119592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D328")]
		[Address(RVA = "0x16C2940", Offset = "0x16C1540", VA = "0x1816C2940")]
		public void ChangeSelect()
		{
		}

		// Token: 0x0601D329 RID: 119593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D329")]
		[Address(RVA = "0x16C29F0", Offset = "0x16C15F0", VA = "0x1816C29F0")]
		public void Render(int id, int currDayId, int selectedId, MonthlySignInData monthlySignInData, bool canTodayCheckin, bool playTodayCheckinEffect)
		{
		}

		// Token: 0x0601D32A RID: 119594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D32A")]
		[Address(RVA = "0x16C2E80", Offset = "0x16C1A80", VA = "0x1816C2E80")]
		private IEnumerator _PlayTodayCheckinEffect()
		{
			return null;
		}

		// Token: 0x0601D32B RID: 119595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D32B")]
		[Address(RVA = "0x16C2DE0", Offset = "0x16C19E0", VA = "0x1816C2DE0")]
		private void _ClearEffectIfNot()
		{
		}

		// Token: 0x0601D32C RID: 119596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D32C")]
		[Address(RVA = "0x16C29E0", Offset = "0x16C15E0", VA = "0x1816C29E0")]
		private void OnDisable()
		{
		}

		// Token: 0x0601D32D RID: 119597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D32D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HomeCheckInGridItemView()
		{
		}

		// Token: 0x04026566 RID: 157030
		[Token(Token = "0x4026566")]
		private const float ALPHA_AFTER_CHECK_IN = 0.3f;

		// Token: 0x04026567 RID: 157031
		[Token(Token = "0x4026567")]
		private const float ALPHA_NOT_CHECK_IN = 1f;

		// Token: 0x04026568 RID: 157032
		[Token(Token = "0x4026568")]
		private const float DELAY_CHECKIN_TODAY_EFFECT_INTERNAL = 0.5f;

		// Token: 0x04026569 RID: 157033
		[Token(Token = "0x4026569")]
		private const int COUNT_THOUSAND_COUNT_LIMIT = 999;

		// Token: 0x0402656A RID: 157034
		[Token(Token = "0x402656A")]
		private const int COUNT_HUNDRED_COUNT_LIMIT = 99;

		// Token: 0x0402656B RID: 157035
		[Token(Token = "0x402656B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _textIndexList;

		// Token: 0x0402656C RID: 157036
		[Token(Token = "0x402656C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelCurrDay;

		// Token: 0x0402656D RID: 157037
		[Token(Token = "0x402656D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0402656E RID: 157038
		[Token(Token = "0x402656E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelCheckInFlag;

		// Token: 0x0402656F RID: 157039
		[Token(Token = "0x402656F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasCheckIn;

		// Token: 0x04026570 RID: 157040
		[Token(Token = "0x4026570")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x04026571 RID: 157041
		[Token(Token = "0x4026571")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _textCountList;

		// Token: 0x04026572 RID: 157042
		[Token(Token = "0x4026572")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCountThousand;

		// Token: 0x04026573 RID: 157043
		[Token(Token = "0x4026573")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelCountHundred;

		// Token: 0x04026574 RID: 157044
		[Token(Token = "0x4026574")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelCountTen;

		// Token: 0x04026575 RID: 157045
		[Token(Token = "0x4026575")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _prefabParticle;

		// Token: 0x04026576 RID: 157046
		[Token(Token = "0x4026576")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _containerParticle;

		// Token: 0x04026577 RID: 157047
		[Token(Token = "0x4026577")]
		[FieldOffset(Offset = "0x78")]
		private int m_cacheId;

		// Token: 0x04026578 RID: 157048
		[Token(Token = "0x4026578")]
		[FieldOffset(Offset = "0x80")]
		private GameObject m_effectHolder;

		// Token: 0x04026579 RID: 157049
		[Token(Token = "0x4026579")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;
	}
}
