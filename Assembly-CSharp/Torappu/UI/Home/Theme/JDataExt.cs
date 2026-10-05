using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C6C RID: 19564
	[Token(Token = "0x2004C6C")]
	public static class JDataExt
	{
		// Token: 0x0601D585 RID: 120197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D585")]
		public static T GetValue<T>(this JObject jdata, string propertyName, T defaultValue)
		{
			return null;
		}

		// Token: 0x0601D586 RID: 120198 RVA: 0x000AB348 File Offset: 0x000A9548
		[Token(Token = "0x601D586")]
		[Address(RVA = "0x16E9DD0", Offset = "0x16E89D0", VA = "0x1816E9DD0")]
		public static Vector2 ParseVector2(this JObject jdata, string propertyName)
		{
			return default(Vector2);
		}

		// Token: 0x0601D587 RID: 120199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D587")]
		[Address(RVA = "0x16E9D60", Offset = "0x16E8960", VA = "0x1816E9D60")]
		public static string ParseString(this JObject jdata, string propertyName)
		{
			return null;
		}

		// Token: 0x0601D588 RID: 120200 RVA: 0x000AB360 File Offset: 0x000A9560
		[Token(Token = "0x601D588")]
		[Address(RVA = "0x16E9CB0", Offset = "0x16E88B0", VA = "0x1816E9CB0")]
		public static Color ParseColor(this JObject jdata, string propertyName)
		{
			return default(Color);
		}

		// Token: 0x0601D589 RID: 120201 RVA: 0x000AB378 File Offset: 0x000A9578
		[Token(Token = "0x601D589")]
		[Address(RVA = "0x16E9C40", Offset = "0x16E8840", VA = "0x1816E9C40")]
		public static bool ParseBoolean(this JObject jdata, string propertyName)
		{
			return default(bool);
		}

		// Token: 0x0601D58A RID: 120202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D58A")]
		public static EnumType ParseStrEnum<EnumType>(this JObject jdata, string propertyName, EnumType defaultValue)
		{
			return null;
		}

		// Token: 0x040269B3 RID: 158131
		[Token(Token = "0x40269B3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2 DEFAULT_VEC2;

		// Token: 0x040269B4 RID: 158132
		[Token(Token = "0x40269B4")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Color DEFAULT_CLR;
	}
}
