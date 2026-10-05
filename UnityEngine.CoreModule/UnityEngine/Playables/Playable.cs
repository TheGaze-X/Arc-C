using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	[RequiredByNativeCode]
	public struct Playable : IPlayable, IEquatable<Playable>
	{
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x170002F4")]
		public static Playable Null
		{
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x5984E60", Offset = "0x5983A60", VA = "0x185984E60")]
			get
			{
				return default(Playable);
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x5984B50", Offset = "0x5983750", VA = "0x185984B50")]
		public static Playable Create(PlayableGraph graph, int inputCount = 0)
		{
			return default(Playable);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x453ADB0", Offset = "0x45399B0", VA = "0x18453ADB0")]
		[VisibleToOtherModules]
		internal Playable(PlayableHandle handle)
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x6000E98")]
		public bool IsPlayableOfType<T>() where T : struct, IPlayable
		{
			return default(bool);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x5984D00", Offset = "0x5983900", VA = "0x185984D00")]
		public Type GetPlayableType()
		{
			return null;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x5984C20", Offset = "0x5983820", VA = "0x185984C20", Slot = "5")]
		public bool Equals(Playable other)
		{
			return default(bool);
		}

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Playable m_NullPlayable;
	}
}
