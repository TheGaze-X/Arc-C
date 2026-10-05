using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[UsedByNativeCode]
	[NativeHeader("Modules/IMGUI/GUIStyle.h")]
	[Serializable]
	[StructLayout(0)]
	public class RectOffset : IFormattable
	{
		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x5937DF0", Offset = "0x59369F0", VA = "0x185937DF0")]
		public RectOffset()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x5937CA0", Offset = "0x59368A0", VA = "0x185937CA0")]
		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.IMGUIModule"
		})]
		internal RectOffset(object sourceStyle, IntPtr source)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x5937780", Offset = "0x5936380", VA = "0x185937780", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x5937CF0", Offset = "0x59368F0", VA = "0x185937CF0")]
		public RectOffset(int left, int right, int top, int bottom)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x5937990", Offset = "0x5936590", VA = "0x185937990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x59379A0", Offset = "0x59365A0", VA = "0x1859379A0", Slot = "4")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x59376E0", Offset = "0x59362E0", VA = "0x1859376E0")]
		private void Destroy()
		{
		}

		// Token: 0x06000292 RID: 658
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5937860", Offset = "0x5936460", VA = "0x185937860")]
		[ThreadAndSerializationSafe]
		[MethodImpl(4096)]
		private static extern IntPtr InternalCreate();

		// Token: 0x06000293 RID: 659
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5937890", Offset = "0x5936490", VA = "0x185937890")]
		[ThreadAndSerializationSafe]
		[MethodImpl(4096)]
		private static extern void InternalDestroy(IntPtr ptr);

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000294 RID: 660
		// (set) Token: 0x06000295 RID: 661
		[Token(Token = "0x170000A4")]
		[NativeProperty("left", false, TargetType.Field)]
		public extern int left { [Token(Token = "0x6000294")] [Address(RVA = "0x5937EB0", Offset = "0x5936AB0", VA = "0x185937EB0")] [MethodImpl(4096)] get; [Token(Token = "0x6000295")] [Address(RVA = "0x5937FF0", Offset = "0x5936BF0", VA = "0x185937FF0")] [MethodImpl(4096)] set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000296 RID: 662
		// (set) Token: 0x06000297 RID: 663
		[Token(Token = "0x170000A5")]
		[NativeProperty("right", false, TargetType.Field)]
		public extern int right { [Token(Token = "0x6000296")] [Address(RVA = "0x5937EF0", Offset = "0x5936AF0", VA = "0x185937EF0")] [MethodImpl(4096)] get; [Token(Token = "0x6000297")] [Address(RVA = "0x5938030", Offset = "0x5936C30", VA = "0x185938030")] [MethodImpl(4096)] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000298 RID: 664
		// (set) Token: 0x06000299 RID: 665
		[Token(Token = "0x170000A6")]
		[NativeProperty("top", false, TargetType.Field)]
		public extern int top { [Token(Token = "0x6000298")] [Address(RVA = "0x5937F30", Offset = "0x5936B30", VA = "0x185937F30")] [MethodImpl(4096)] get; [Token(Token = "0x6000299")] [Address(RVA = "0x5938070", Offset = "0x5936C70", VA = "0x185938070")] [MethodImpl(4096)] set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600029A RID: 666
		// (set) Token: 0x0600029B RID: 667
		[Token(Token = "0x170000A7")]
		[NativeProperty("bottom", false, TargetType.Field)]
		public extern int bottom { [Token(Token = "0x600029A")] [Address(RVA = "0x5937E30", Offset = "0x5936A30", VA = "0x185937E30")] [MethodImpl(4096)] get; [Token(Token = "0x600029B")] [Address(RVA = "0x5937FB0", Offset = "0x5936BB0", VA = "0x185937FB0")] [MethodImpl(4096)] set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600029C RID: 668
		[Token(Token = "0x170000A8")]
		public extern int horizontal { [Token(Token = "0x600029C")] [Address(RVA = "0x5937E70", Offset = "0x5936A70", VA = "0x185937E70")] [MethodImpl(4096)] get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600029D RID: 669
		[Token(Token = "0x170000A9")]
		public extern int vertical { [Token(Token = "0x600029D")] [Address(RVA = "0x5937F70", Offset = "0x5936B70", VA = "0x185937F70")] [MethodImpl(4096)] get; }

		// Token: 0x0600029E RID: 670 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x5937930", Offset = "0x5936530", VA = "0x185937930")]
		public Rect Remove(Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x0600029F RID: 671
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x59378D0", Offset = "0x59364D0", VA = "0x1859378D0")]
		[MethodImpl(4096)]
		private extern void Remove_Injected(ref Rect rect, out Rect ret);

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.IMGUIModule"
		})]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object m_SourceStyle;
	}
}
