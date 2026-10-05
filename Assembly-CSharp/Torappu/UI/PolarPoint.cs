using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A13 RID: 14867
	[Token(Token = "0x2003A13")]
	[Serializable]
	public struct PolarPoint : IHotfixable
	{
		// Token: 0x06017767 RID: 96103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017767")]
		[Address(RVA = "0xFC89C0", Offset = "0xFC75C0", VA = "0x180FC89C0")]
		public PolarPoint(float p, float r)
		{
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x06017768 RID: 96104 RVA: 0x00096A20 File Offset: 0x00094C20
		[Token(Token = "0x17003833")]
		public static PolarPoint zero
		{
			[Token(Token = "0x6017768")]
			[Address(RVA = "0xFC8B90", Offset = "0xFC7790", VA = "0x180FC8B90")]
			get
			{
				return default(PolarPoint);
			}
		}

		// Token: 0x06017769 RID: 96105 RVA: 0x00096A38 File Offset: 0x00094C38
		[Token(Token = "0x6017769")]
		[Address(RVA = "0xFC8C40", Offset = "0xFC7840", VA = "0x180FC8C40")]
		public static PolarPoint operator +(PolarPoint left, PolarPoint right)
		{
			return default(PolarPoint);
		}

		// Token: 0x0601776A RID: 96106 RVA: 0x00096A50 File Offset: 0x00094C50
		[Token(Token = "0x601776A")]
		[Address(RVA = "0xFC9280", Offset = "0xFC7E80", VA = "0x180FC9280")]
		public static PolarPoint operator -(PolarPoint left, PolarPoint right)
		{
			return default(PolarPoint);
		}

		// Token: 0x0601776B RID: 96107 RVA: 0x00096A68 File Offset: 0x00094C68
		[Token(Token = "0x601776B")]
		[Address(RVA = "0xFC9060", Offset = "0xFC7C60", VA = "0x180FC9060")]
		public static PolarPoint operator *(PolarPoint vec, int k)
		{
			return default(PolarPoint);
		}

		// Token: 0x0601776C RID: 96108 RVA: 0x00096A80 File Offset: 0x00094C80
		[Token(Token = "0x601776C")]
		[Address(RVA = "0xFC9170", Offset = "0xFC7D70", VA = "0x180FC9170")]
		public static PolarPoint operator *(int k, PolarPoint vec)
		{
			return default(PolarPoint);
		}

		// Token: 0x0601776D RID: 96109 RVA: 0x00096A98 File Offset: 0x00094C98
		[Token(Token = "0x601776D")]
		[Address(RVA = "0xFC8D60", Offset = "0xFC7960", VA = "0x180FC8D60")]
		public static PolarPoint operator /(PolarPoint vec, float k)
		{
			return default(PolarPoint);
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0601776E RID: 96110 RVA: 0x00096AB0 File Offset: 0x00094CB0
		[Token(Token = "0x17003834")]
		public PolarPoint normalized
		{
			[Token(Token = "0x601776E")]
			[Address(RVA = "0xFC8A40", Offset = "0xFC7640", VA = "0x180FC8A40")]
			get
			{
				return default(PolarPoint);
			}
		}

		// Token: 0x0601776F RID: 96111 RVA: 0x00096AC8 File Offset: 0x00094CC8
		[Token(Token = "0x601776F")]
		[Address(RVA = "0xFC8E80", Offset = "0xFC7A80", VA = "0x180FC8E80")]
		public static bool operator ==(PolarPoint left, PolarPoint right)
		{
			return default(bool);
		}

		// Token: 0x06017770 RID: 96112 RVA: 0x00096AE0 File Offset: 0x00094CE0
		[Token(Token = "0x6017770")]
		[Address(RVA = "0xFC8FC0", Offset = "0xFC7BC0", VA = "0x180FC8FC0")]
		public static bool operator !=(PolarPoint left, PolarPoint right)
		{
			return default(bool);
		}

		// Token: 0x06017771 RID: 96113 RVA: 0x00096AF8 File Offset: 0x00094CF8
		[Token(Token = "0x6017771")]
		[Address(RVA = "0xFC84E0", Offset = "0xFC70E0", VA = "0x180FC84E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06017772 RID: 96114 RVA: 0x00096B10 File Offset: 0x00094D10
		[Token(Token = "0x6017772")]
		[Address(RVA = "0xFC85A0", Offset = "0xFC71A0", VA = "0x180FC85A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06017773 RID: 96115 RVA: 0x00096B28 File Offset: 0x00094D28
		[Token(Token = "0x6017773")]
		[Address(RVA = "0xFC88A0", Offset = "0xFC74A0", VA = "0x180FC88A0")]
		public Vector2 ToFloat()
		{
			return default(Vector2);
		}

		// Token: 0x06017774 RID: 96116 RVA: 0x00096B40 File Offset: 0x00094D40
		[Token(Token = "0x6017774")]
		[Address(RVA = "0xFC8630", Offset = "0xFC7230", VA = "0x180FC8630")]
		public Vector2 ToCrossCoord(float degreePerLogicUnit)
		{
			return default(Vector2);
		}

		// Token: 0x06017775 RID: 96117 RVA: 0x00096B58 File Offset: 0x00094D58
		[Token(Token = "0x6017775")]
		[Address(RVA = "0xFC87C0", Offset = "0xFC73C0", VA = "0x180FC87C0")]
		public static Vector2 ToCrossCoord(Vector2 polarPoint, float degreePerLogicUnit)
		{
			return default(Vector2);
		}

		// Token: 0x06017776 RID: 96118 RVA: 0x00096B70 File Offset: 0x00094D70
		[Token(Token = "0x6017776")]
		[Address(RVA = "0xFC8910", Offset = "0xFC7510", VA = "0x180FC8910")]
		private bool <>xLuaBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		// Token: 0x06017777 RID: 96119 RVA: 0x00096B88 File Offset: 0x00094D88
		[Token(Token = "0x6017777")]
		[Address(RVA = "0xFC8970", Offset = "0xFC7570", VA = "0x180FC8970")]
		private int <>xLuaBaseProxy_GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401C575 RID: 116085
		[Token(Token = "0x401C575")]
		[FieldOffset(Offset = "0x0")]
		public float p;

		// Token: 0x0401C576 RID: 116086
		[Token(Token = "0x401C576")]
		[FieldOffset(Offset = "0x4")]
		public float r;

		// Token: 0x0401C577 RID: 116087
		[Token(Token = "0x401C577")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C578 RID: 116088
		[Token(Token = "0x401C578")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_zero;

		// Token: 0x0401C579 RID: 116089
		[Token(Token = "0x401C579")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_op_Addition;

		// Token: 0x0401C57A RID: 116090
		[Token(Token = "0x401C57A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_op_Subtraction;

		// Token: 0x0401C57B RID: 116091
		[Token(Token = "0x401C57B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_op_Multiply;

		// Token: 0x0401C57C RID: 116092
		[Token(Token = "0x401C57C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_op_Multiply;

		// Token: 0x0401C57D RID: 116093
		[Token(Token = "0x401C57D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_op_Division;

		// Token: 0x0401C57E RID: 116094
		[Token(Token = "0x401C57E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_normalized;

		// Token: 0x0401C57F RID: 116095
		[Token(Token = "0x401C57F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_op_Equality;

		// Token: 0x0401C580 RID: 116096
		[Token(Token = "0x401C580")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_op_Inequality;

		// Token: 0x0401C581 RID: 116097
		[Token(Token = "0x401C581")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Equals;

		// Token: 0x0401C582 RID: 116098
		[Token(Token = "0x401C582")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetHashCode;

		// Token: 0x0401C583 RID: 116099
		[Token(Token = "0x401C583")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ToFloat;

		// Token: 0x0401C584 RID: 116100
		[Token(Token = "0x401C584")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ToCrossCoord;

		// Token: 0x0401C585 RID: 116101
		[Token(Token = "0x401C585")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_ToCrossCoord;
	}
}
