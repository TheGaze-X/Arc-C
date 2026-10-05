using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Playables
{
	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	public struct PlayableBinding
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F8")]
		public string streamName
		{
			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F9")]
		public Object sourceObject
		{
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x5981B50", Offset = "0x5980750", VA = "0x185981B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002FA")]
		public Type outputTargetType
		{
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x59819E0", Offset = "0x59805E0", VA = "0x1859819E0")]
		internal PlayableOutput CreateOutput(PlayableGraph graph)
		{
			return default(PlayableOutput);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x5981940", Offset = "0x5980540", VA = "0x185981940")]
		[VisibleToOtherModules]
		internal static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction)
		{
			return default(PlayableBinding);
		}

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x0")]
		private string m_StreamName;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x8")]
		private Object m_SourceObject;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x10")]
		private Type m_SourceBindingType;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x18")]
		private PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayableBinding[] None;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x8")]
		public static readonly double DefaultDuration;

		// Token: 0x0200028E RID: 654
		// (Invoke) Token: 0x06000EB5 RID: 3765
		[Token(Token = "0x200028E")]
		[VisibleToOtherModules]
		internal delegate PlayableOutput CreateOutputMethod(PlayableGraph graph, string name);
	}
}
