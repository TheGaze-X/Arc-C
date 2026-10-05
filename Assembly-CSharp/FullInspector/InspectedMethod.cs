using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BDE RID: 31710
	[Token(Token = "0x2007BDE")]
	public class InspectedMethod
	{
		// Token: 0x0602C604 RID: 181764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C604")]
		[Address(RVA = "0x285B990", Offset = "0x285A590", VA = "0x18285B990")]
		public InspectedMethod(MethodInfo method)
		{
		}

		// Token: 0x170067E9 RID: 26601
		// (get) Token: 0x0602C605 RID: 181765 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C606 RID: 181766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067E9")]
		public MethodInfo Method
		{
			[Token(Token = "0x602C605")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C606")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170067EA RID: 26602
		// (get) Token: 0x0602C607 RID: 181767 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C608 RID: 181768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067EA")]
		public GUIContent DisplayLabel
		{
			[Token(Token = "0x602C607")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C608")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170067EB RID: 26603
		// (get) Token: 0x0602C609 RID: 181769 RVA: 0x000DFD40 File Offset: 0x000DDF40
		// (set) Token: 0x0602C60A RID: 181770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067EB")]
		public bool HasArguments
		{
			[Token(Token = "0x602C609")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C60A")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602C60B RID: 181771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C60B")]
		[Address(RVA = "0x285B7A0", Offset = "0x285A3A0", VA = "0x18285B7A0")]
		public void Invoke(object instance)
		{
		}
	}
}
