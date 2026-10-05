using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectAttribute : Attribute, IRuntimeAttribute, IVisibility
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public InspectorLevel Level
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return InspectorLevel.Basic;
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public bool Condition
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public int Priority
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4F04F0", Offset = "0x4EF0F0", VA = "0x1804F04F0", Slot = "12")]
		public bool IsItemVisible(object[] instances, object[] values)
		{
			return default(bool);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "13")]
		public InspectorLevel GetItemLevel(object[] parents, object[] values)
		{
			return InspectorLevel.Basic;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "14")]
		public int GetItemPriority(object[] parents, object[] values)
		{
			return 0;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public string MethodName
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003F")]
		public Type Template
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x4F11A0", Offset = "0x4EFDA0", VA = "0x1804F11A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000040")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x4F1140", Offset = "0x4EFD40", VA = "0x1804F1140", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x4F0D00", Offset = "0x4EF900", VA = "0x1804F0D00")]
		public InspectAttribute()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4F0CA0", Offset = "0x4EF8A0", VA = "0x1804F0CA0")]
		public InspectAttribute(int priority)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x4F0C40", Offset = "0x4EF840", VA = "0x1804F0C40")]
		public InspectAttribute(InspectorLevel level)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4F0EB0", Offset = "0x4EFAB0", VA = "0x1804F0EB0")]
		public InspectAttribute(InspectorLevel level, int priority)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4F0F20", Offset = "0x4EFB20", VA = "0x1804F0F20")]
		public InspectAttribute(InspectorLevel level, string methodName)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4F0FD0", Offset = "0x4EFBD0", VA = "0x1804F0FD0")]
		public InspectAttribute(InspectorLevel level, string methodName, int priority)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4F1120", Offset = "0x4EFD20", VA = "0x1804F1120")]
		public InspectAttribute(InspectorLevel level, string methodName, bool condition)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4F0E80", Offset = "0x4EFA80", VA = "0x1804F0E80")]
		public InspectAttribute(string methodName)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4F0FA0", Offset = "0x4EFBA0", VA = "0x1804F0FA0")]
		public InspectAttribute(string methodName, int priority)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4F0B90", Offset = "0x4EF790", VA = "0x1804F0B90")]
		public InspectAttribute(string methodName, bool condition)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4F0F40", Offset = "0x4EFB40", VA = "0x1804F0F40")]
		public InspectAttribute(string methodName, bool condition, int priority)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4F1020", Offset = "0x4EFC20", VA = "0x1804F1020")]
		public InspectAttribute(InspectorLevel level, string methodName, bool condition, int priority)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4F0FF0", Offset = "0x4EFBF0", VA = "0x1804F0FF0")]
		public InspectAttribute(Delegate method)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4F0BF0", Offset = "0x4EF7F0", VA = "0x1804F0BF0")]
		public InspectAttribute(Delegate method, int priority)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4F0F70", Offset = "0x4EFB70", VA = "0x1804F0F70")]
		public InspectAttribute(Delegate method, bool condition)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4F0BC0", Offset = "0x4EF7C0", VA = "0x1804F0BC0")]
		public InspectAttribute(Delegate method, bool condition, int priority)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4F0E60", Offset = "0x4EFA60", VA = "0x1804F0E60")]
		public InspectAttribute(InspectorLevel level, Delegate method)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4F0C20", Offset = "0x4EF820", VA = "0x1804F0C20")]
		public InspectAttribute(InspectorLevel level, Delegate method, int priority)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4F0D50", Offset = "0x4EF950", VA = "0x1804F0D50")]
		public InspectAttribute(InspectorLevel level, Delegate method, bool condition, int priority)
		{
		}

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x10")]
		private InspectorLevel level;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x14")]
		private bool condition;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		private int priority;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		private string methodName;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x28")]
		private List<Delegate> delegates;

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x0600010C RID: 268
		[Token(Token = "0x2000022")]
		public delegate bool InspectDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000110 RID: 272
		[Token(Token = "0x2000023")]
		public delegate bool InspectStaticDelegate(InspectAttribute inspect, object instance, object value);
	}
}
