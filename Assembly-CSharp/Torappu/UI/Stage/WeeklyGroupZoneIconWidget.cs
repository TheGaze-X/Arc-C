using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006792 RID: 26514
	[Token(Token = "0x2006792")]
	public class WeeklyGroupZoneIconWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602607F RID: 155775 RVA: 0x000C9BB8 File Offset: 0x000C7DB8
		[Token(Token = "0x602607F")]
		[Address(RVA = "0x21279E0", Offset = "0x21265E0", VA = "0x1821279E0")]
		public Vector2 GetIconPos(GameDayOfWeek day)
		{
			return default(Vector2);
		}

		// Token: 0x06026080 RID: 155776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026080")]
		public void Render<T>(WeekStruct<T> weekConfig, WeeklyGroupZoneIconWidget.GetOpenState<T> getAction)
		{
		}

		// Token: 0x06026081 RID: 155777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026081")]
		[Address(RVA = "0x2127AE0", Offset = "0x21266E0", VA = "0x182127AE0")]
		public WeeklyGroupZoneIconWidget()
		{
		}

		// Token: 0x040357FF RID: 219135
		[Token(Token = "0x40357FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _iconList;

		// Token: 0x04035800 RID: 219136
		[Token(Token = "0x4035800")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _iconActive;

		// Token: 0x04035801 RID: 219137
		[Token(Token = "0x4035801")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _iconInactive;

		// Token: 0x04035802 RID: 219138
		[Token(Token = "0x4035802")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _iconForceOpen;

		// Token: 0x04035803 RID: 219139
		[Token(Token = "0x4035803")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _iconForceOpenToday;

		// Token: 0x04035804 RID: 219140
		[Token(Token = "0x4035804")]
		private const int WEEK_COUNT = 7;

		// Token: 0x04035805 RID: 219141
		[Token(Token = "0x4035805")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIconPos;

		// Token: 0x04035806 RID: 219142
		[Token(Token = "0x4035806")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035807 RID: 219143
		[Token(Token = "0x4035807")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006793 RID: 26515
		// (Invoke) Token: 0x06026083 RID: 155779
		[Token(Token = "0x2006793")]
		public delegate ZoneOpenState GetOpenState<T>(T state);
	}
}
