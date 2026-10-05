using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field)]
	public class BackgroundAttribute : Attribute, IRuntimeAttribute<Color>, IRuntimeAttribute
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public Color Color
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x4E6EA0", Offset = "0x4E5AA0", VA = "0x1804E6EA0")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public string MethodName
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000007")]
		public Type Template
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x4E6E40", Offset = "0x4E5A40", VA = "0x1804E6E40", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000008")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x4E6DE0", Offset = "0x4E59E0", VA = "0x1804E6DE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4E65F0", Offset = "0x4E51F0", VA = "0x1804E65F0", Slot = "7")]
		public Color Invoke(int index, object instance, object value)
		{
			return default(Color);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4E69E0", Offset = "0x4E55E0", VA = "0x1804E69E0")]
		public BackgroundAttribute(string methodName)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4E6CE0", Offset = "0x4E58E0", VA = "0x1804E6CE0")]
		public BackgroundAttribute(Delegate method)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4E6BD0", Offset = "0x4E57D0", VA = "0x1804E6BD0")]
		public BackgroundAttribute(float r, float g, float b)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4E6AC0", Offset = "0x4E56C0", VA = "0x1804E6AC0")]
		public BackgroundAttribute(float r, float g, float b, float a)
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private Color color;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		private string methodName;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		private List<Delegate> delegates;

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000023 RID: 35
		[Token(Token = "0x2000007")]
		public delegate Color BackgroundDelegate();

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000027 RID: 39
		[Token(Token = "0x2000008")]
		public delegate Color BackgroundStaticDelegate(BackgroundAttribute background, object instance, object value);
	}
}
