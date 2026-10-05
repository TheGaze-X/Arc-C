using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200263B RID: 9787
	[Token(Token = "0x200263B")]
	[Serializable]
	public class BuffTemplate
	{
		// Token: 0x0601002B RID: 65579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601002B")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0601002C RID: 65580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601002C")]
		[Address(RVA = "0x778FE0", Offset = "0x777BE0", VA = "0x180778FE0")]
		public static implicit operator BuffTemplate(BuffTemplateDBData dbData)
		{
			return null;
		}

		// Token: 0x0601002D RID: 65581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601002D")]
		[Address(RVA = "0x7792A0", Offset = "0x777EA0", VA = "0x1807792A0")]
		public static implicit operator BuffTemplateDBData(BuffTemplate template)
		{
			return null;
		}

		// Token: 0x0601002E RID: 65582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601002E")]
		[Address(RVA = "0x778B90", Offset = "0x777790", VA = "0x180778B90")]
		public BuffTemplateDBData ConvertToDBData()
		{
			return null;
		}

		// Token: 0x0601002F RID: 65583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601002F")]
		[Address(RVA = "0x778F20", Offset = "0x777B20", VA = "0x180778F20")]
		public BuffTemplate()
		{
		}

		// Token: 0x04011CB2 RID: 72882
		[Token(Token = "0x4011CB2")]
		[FieldOffset(Offset = "0x10")]
		public string templateKey;

		// Token: 0x04011CB3 RID: 72883
		[Token(Token = "0x4011CB3")]
		[FieldOffset(Offset = "0x18")]
		public string effectKey;

		// Token: 0x04011CB4 RID: 72884
		[Token(Token = "0x4011CB4")]
		[FieldOffset(Offset = "0x20")]
		public BuffData.OnEventPriority onEventPriority;

		// Token: 0x04011CB5 RID: 72885
		[Token(Token = "0x4011CB5")]
		[FieldOffset(Offset = "0x28")]
		public BuffTemplate.EventToActionMap eventToActions;

		// Token: 0x0200263C RID: 9788
		[Token(Token = "0x200263C")]
		[Serializable]
		public class EventToAction : ActionKV<Buff.Event>
		{
			// Token: 0x06010030 RID: 65584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010030")]
			[Address(RVA = "0x77BE60", Offset = "0x77AA60", VA = "0x18077BE60")]
			public EventToAction()
			{
			}
		}

		// Token: 0x0200263D RID: 9789
		[Token(Token = "0x200263D")]
		[Serializable]
		public class EventToActionMap : ActionDict<Buff.Event, BuffTemplate.EventToAction>
		{
			// Token: 0x06010031 RID: 65585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010031")]
			[Address(RVA = "0x77BE20", Offset = "0x77AA20", VA = "0x18077BE20")]
			public EventToActionMap()
			{
			}
		}
	}
}
