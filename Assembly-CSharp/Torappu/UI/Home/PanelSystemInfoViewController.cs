using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C45 RID: 19525
	[Token(Token = "0x2004C45")]
	public class PanelSystemInfoViewController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D4F7 RID: 120055 RVA: 0x000AB2A0 File Offset: 0x000A94A0
		[Token(Token = "0x601D4F7")]
		[Address(RVA = "0x16F2FB0", Offset = "0x16F1BB0", VA = "0x1816F2FB0")]
		private bool _CheckSameDisplay(DateTime lhs, DateTime rhs)
		{
			return default(bool);
		}

		// Token: 0x0601D4F8 RID: 120056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4F8")]
		[Address(RVA = "0x16F3150", Offset = "0x16F1D50", VA = "0x1816F3150")]
		private void _UpdateSystemInfo()
		{
		}

		// Token: 0x0601D4F9 RID: 120057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4F9")]
		[Address(RVA = "0x16F2F50", Offset = "0x16F1B50", VA = "0x1816F2F50")]
		private void Update()
		{
		}

		// Token: 0x0601D4FA RID: 120058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4FA")]
		[Address(RVA = "0x16F3650", Offset = "0x16F2250", VA = "0x1816F3650")]
		public PanelSystemInfoViewController()
		{
		}

		// Token: 0x04026907 RID: 157959
		[Token(Token = "0x4026907")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _curTimeLabel;

		// Token: 0x04026908 RID: 157960
		[Token(Token = "0x4026908")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _batteryImage;

		// Token: 0x04026909 RID: 157961
		[Token(Token = "0x4026909")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite[] _batterySprites;

		// Token: 0x0402690A RID: 157962
		[Token(Token = "0x402690A")]
		[FieldOffset(Offset = "0x30")]
		private DateTime? m_cachedShowTime;

		// Token: 0x0402690B RID: 157963
		[Token(Token = "0x402690B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckSameDisplay;

		// Token: 0x0402690C RID: 157964
		[Token(Token = "0x402690C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateSystemInfo;

		// Token: 0x0402690D RID: 157965
		[Token(Token = "0x402690D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402690E RID: 157966
		[Token(Token = "0x402690E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
