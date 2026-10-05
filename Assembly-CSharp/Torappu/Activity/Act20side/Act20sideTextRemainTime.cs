using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200768E RID: 30350
	[Token(Token = "0x200768E")]
	public class Act20sideTextRemainTime : AbstractRemainTime
	{
		// Token: 0x0602AB06 RID: 174854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB06")]
		[Address(RVA = "0x267C200", Offset = "0x267AE00", VA = "0x18267C200", Slot = "4")]
		public override void SetRemainTime(TimeSpan time)
		{
		}

		// Token: 0x0602AB07 RID: 174855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB07")]
		[Address(RVA = "0x267C340", Offset = "0x267AF40", VA = "0x18267C340")]
		private string _FormatRemainTime(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x0602AB08 RID: 174856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB08")]
		[Address(RVA = "0x267C570", Offset = "0x267B170", VA = "0x18267C570")]
		public Act20sideTextRemainTime()
		{
		}

		// Token: 0x0403D812 RID: 251922
		[Token(Token = "0x403D812")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0403D813 RID: 251923
		[Token(Token = "0x403D813")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _remainTimeColor;

		// Token: 0x0403D814 RID: 251924
		[Token(Token = "0x403D814")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRemainTime;

		// Token: 0x0403D815 RID: 251925
		[Token(Token = "0x403D815")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FormatRemainTime;

		// Token: 0x0403D816 RID: 251926
		[Token(Token = "0x403D816")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
