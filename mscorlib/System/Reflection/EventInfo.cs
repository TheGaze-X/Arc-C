using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Mono;

namespace System.Reflection
{
	// Token: 0x020004F8 RID: 1272
	[Token(Token = "0x20004F8")]
	[System.Serializable]
	public abstract class EventInfo : MemberInfo
	{
		// Token: 0x06002445 RID: 9285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected EventInfo()
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x00014580 File Offset: 0x00012780
		[Token(Token = "0x170004AC")]
		public override MemberTypes MemberType
		{
			[Token(Token = "0x6002446")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "7")]
			get
			{
				return (MemberTypes)0;
			}
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002447")]
		[Address(RVA = "0x4BCF0A0", Offset = "0x4BCDCA0", VA = "0x184BCF0A0", Slot = "16")]
		public MethodInfo GetAddMethod()
		{
			return null;
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x4B6B600", Offset = "0x4B6A200", VA = "0x184B6B600", Slot = "17")]
		public MethodInfo GetRemoveMethod()
		{
			return null;
		}

		// Token: 0x06002449 RID: 9289
		[Token(Token = "0x6002449")]
		public abstract MethodInfo GetAddMethod(bool nonPublic);

		// Token: 0x0600244A RID: 9290
		[Token(Token = "0x600244A")]
		public abstract MethodInfo GetRemoveMethod(bool nonPublic);

		// Token: 0x0600244B RID: 9291
		[Token(Token = "0x600244B")]
		public abstract MethodInfo GetRaiseMethod(bool nonPublic);

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004AD")]
		public virtual System.Type EventHandlerType
		{
			[Token(Token = "0x600244C")]
			[Address(RVA = "0x4BD3260", Offset = "0x4BD1E60", VA = "0x184BD3260", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00014598 File Offset: 0x00012798
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x000145B0 File Offset: 0x000127B0
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x000145C8 File Offset: 0x000127C8
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool operator ==(EventInfo left, EventInfo right)
		{
			return default(bool);
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x000145E0 File Offset: 0x000127E0
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x4ED060", Offset = "0x4EBC60", VA = "0x1804ED060")]
		public static bool operator !=(EventInfo left, EventInfo right)
		{
			return default(bool);
		}

		// Token: 0x06002451 RID: 9297
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x4BD3400", Offset = "0x4BD2000", VA = "0x184BD3400")]
		[MethodImpl(4096)]
		private static extern EventInfo internal_from_handle_type(System.IntPtr event_handle, System.IntPtr type_handle);

		// Token: 0x06002452 RID: 9298 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x4BD3150", Offset = "0x4BD1D50", VA = "0x184BD3150")]
		internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, System.RuntimeTypeHandle reflectedType)
		{
			return null;
		}

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40014BE")]
		[FieldOffset(Offset = "0x10")]
		private EventInfo.AddEventAdapter cached_add_event;

		// Token: 0x020004F9 RID: 1273
		// (Invoke) Token: 0x06002454 RID: 9300
		[Token(Token = "0x20004F9")]
		private delegate void AddEventAdapter(object _this, System.Delegate dele);
	}
}
