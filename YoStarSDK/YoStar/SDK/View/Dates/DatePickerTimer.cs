using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public static class DatePickerTimer
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		private static DatePickerTimerComponent timerComponent
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x5C46860", Offset = "0x5C45460", VA = "0x185C46860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x17000080")]
		public static bool IsFirstFrame
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x5C46800", Offset = "0x5C45400", VA = "0x185C46800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00003374 File Offset: 0x00001574
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000081")]
		private static bool IsQuitting
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x5C46820", Offset = "0x5C45420", VA = "0x185C46820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x5C46A30", Offset = "0x5C45630", VA = "0x185C46A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x5C467C0", Offset = "0x5C453C0", VA = "0x185C467C0")]
		public static void StartCoroutine(IEnumerator coroutine)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x5C46760", Offset = "0x5C45360", VA = "0x185C46760")]
		public static WaitForSecondsRealtime GetWaitForSecondsRealtimeInstruction(float seconds)
		{
			return null;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x5C46700", Offset = "0x5C45300", VA = "0x185C46700")]
		public static WaitForSeconds GetWaitForSecondsInstruction(float seconds)
		{
			return null;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void EditorUpdate()
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x5C46590", Offset = "0x5C45190", VA = "0x185C46590")]
		public static void DelayedCall(float delay, Action action, MonoBehaviour actionTarget, bool forceEvenIfObjectIsInactive = false)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x5C46560", Offset = "0x5C45160", VA = "0x185C46560")]
		public static void AtEndOfFrame(Action action, MonoBehaviour actionTarget, bool forceEvenIfObjectIsInactive = false)
		{
		}

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x0")]
		private static DatePickerTimerComponent _timerComponent;
	}
}
