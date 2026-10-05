using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	internal class ClickDetector
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		internal static int s_DoubleClickTime
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x5A27480", Offset = "0x5A26080", VA = "0x185A27480")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x5A274D0", Offset = "0x5A260D0", VA = "0x185A274D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x5A27250", Offset = "0x5A25E50", VA = "0x185A27250")]
		public ClickDetector()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5A27000", Offset = "0x5A25C00", VA = "0x185A27000")]
		private void StartClickTracking(EventBase evt)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x5A26BD0", Offset = "0x5A257D0", VA = "0x185A26BD0")]
		private void SendClickEvent(EventBase evt)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x5A264E0", Offset = "0x5A250E0", VA = "0x185A264E0")]
		private void CancelClickTracking(EventBase evt)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5A26850", Offset = "0x5A25450", VA = "0x185A26850")]
		public void ProcessEvent(EventBase evt)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5A266D0", Offset = "0x5A252D0", VA = "0x185A266D0")]
		private static bool ContainsPointer(VisualElement element, Vector2 position)
		{
			return default(bool);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5A26580", Offset = "0x5A25180", VA = "0x185A26580")]
		internal void Cleanup(List<VisualElement> elements)
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x10")]
		private List<ClickDetector.ButtonClickStatus> m_ClickStatus;

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		private class ButtonClickStatus
		{
			// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x5A26470", Offset = "0x5A25070", VA = "0x185A26470")]
			public void Reset()
			{
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ButtonClickStatus()
			{
			}

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x10")]
			public VisualElement m_Target;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 m_PointerDownPosition;

			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x28")]
			public long m_LastPointerDownTime;

			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x30")]
			public int m_ClickCount;
		}
	}
}
