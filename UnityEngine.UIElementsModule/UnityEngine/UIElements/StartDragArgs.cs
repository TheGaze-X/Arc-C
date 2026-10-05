using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	internal struct StartDragArgs
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x5AEBBA0", Offset = "0x5AEA7A0", VA = "0x185AEBBA0")]
		public StartDragArgs(string title, DragVisualMode visualMode)
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000245")]
		public readonly string title
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x17000246")]
		public readonly DragVisualMode visualMode
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			get
			{
				return DragVisualMode.None;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000247")]
		internal Hashtable genericData
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000248")]
		internal IEnumerable<Object> unityObjectReferences
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x5AEBAE0", Offset = "0x5AEA6E0", VA = "0x185AEBAE0")]
		public void SetGenericData(string key, object data)
		{
		}
	}
}
