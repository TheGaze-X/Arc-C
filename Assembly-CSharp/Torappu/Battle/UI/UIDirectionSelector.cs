using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x02003309 RID: 13065
	[Token(Token = "0x2003309")]
	public class UIDirectionSelector : MonoBehaviour
	{
		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x06014BFF RID: 84991 RVA: 0x00088380 File Offset: 0x00086580
		[Token(Token = "0x17003121")]
		public bool isActive
		{
			[Token(Token = "0x6014BFF")]
			[Address(RVA = "0xD29AB0", Offset = "0xD286B0", VA = "0x180D29AB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014C00 RID: 84992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C00")]
		[Address(RVA = "0xD29780", Offset = "0xD28380", VA = "0x180D29780")]
		public void Show(Tile tile, Character dummy, Action<bool, SharedConsts.Direction> cb)
		{
		}

		// Token: 0x06014C01 RID: 84993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C01")]
		[Address(RVA = "0xD291F0", Offset = "0xD27DF0", VA = "0x180D291F0")]
		public void OnCancelled()
		{
		}

		// Token: 0x06014C02 RID: 84994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C02")]
		[Address(RVA = "0xD29200", Offset = "0xD27E00", VA = "0x180D29200")]
		public void OnDirectionClicked()
		{
		}

		// Token: 0x06014C03 RID: 84995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C03")]
		[Address(RVA = "0xD29270", Offset = "0xD27E70", VA = "0x180D29270")]
		public void OnDirectionHover(SharedConsts.Direction direction)
		{
		}

		// Token: 0x06014C04 RID: 84996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C04")]
		[Address(RVA = "0xD29660", Offset = "0xD28260", VA = "0x180D29660")]
		public void OnJoystickMove(Vector2 offset)
		{
		}

		// Token: 0x06014C05 RID: 84997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C05")]
		[Address(RVA = "0xD296D0", Offset = "0xD282D0", VA = "0x180D296D0")]
		public void OnJoystickUp()
		{
		}

		// Token: 0x06014C06 RID: 84998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C06")]
		[Address(RVA = "0xD29950", Offset = "0xD28550", VA = "0x180D29950")]
		private void _EndInternal(bool selected, SharedConsts.Direction direction)
		{
		}

		// Token: 0x06014C07 RID: 84999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C07")]
		[Address(RVA = "0xD29A50", Offset = "0xD28650", VA = "0x180D29A50")]
		public UIDirectionSelector()
		{
		}

		// Token: 0x04018AD9 RID: 101081
		[Token(Token = "0x4018AD9")]
		private const float JOYSTICK_MOVE_THRESHOLD = 0.5f;

		// Token: 0x04018ADA RID: 101082
		[Token(Token = "0x4018ADA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFollower _follower;

		// Token: 0x04018ADB RID: 101083
		[Token(Token = "0x4018ADB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDirectionArrow[] _arrows;

		// Token: 0x04018ADC RID: 101084
		[Token(Token = "0x4018ADC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateFadeSwitcher _cancelHintPanel;

		// Token: 0x04018ADD RID: 101085
		[Token(Token = "0x4018ADD")]
		[FieldOffset(Offset = "0x30")]
		private Character m_dummy;

		// Token: 0x04018ADE RID: 101086
		[Token(Token = "0x4018ADE")]
		[FieldOffset(Offset = "0x38")]
		private Action<bool, SharedConsts.Direction> m_callback;

		// Token: 0x04018ADF RID: 101087
		[Token(Token = "0x4018ADF")]
		[FieldOffset(Offset = "0x40")]
		private SharedConsts.Direction m_currentDirection;

		// Token: 0x04018AE0 RID: 101088
		[Token(Token = "0x4018AE0")]
		[FieldOffset(Offset = "0x44")]
		private bool m_canShowCancelHint;
	}
}
