using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200286D RID: 10349
	[Token(Token = "0x200286D")]
	[Serializable]
	public class ParamKeyValue : IEquatable<ParamKeyValue>
	{
		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06011366 RID: 70502 RVA: 0x0006A158 File Offset: 0x00068358
		// (set) Token: 0x06011367 RID: 70503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025E5")]
		public ParamRealType type
		{
			[Token(Token = "0x6011366")]
			[Address(RVA = "0x5C84B0", Offset = "0x5C70B0", VA = "0x1805C84B0")]
			get
			{
				return ParamRealType.Invalid;
			}
			[Token(Token = "0x6011367")]
			[Address(RVA = "0x919FD0", Offset = "0x918BD0", VA = "0x180919FD0")]
			set
			{
			}
		}

		// Token: 0x06011368 RID: 70504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011368")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ParamKeyValue()
		{
		}

		// Token: 0x06011369 RID: 70505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011369")]
		public static ParamKeyValue New<T>(string key, T value)
		{
			return null;
		}

		// Token: 0x0601136A RID: 70506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601136A")]
		public static ParamKeyValue New<T>(string key, List<T> value)
		{
			return null;
		}

		// Token: 0x0601136B RID: 70507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601136B")]
		public static ParamKeyValue New<T>(string key, ParamRealType type, T value)
		{
			return null;
		}

		// Token: 0x0601136C RID: 70508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601136C")]
		public static ParamKeyValue New<T>(string key, ParamRealType type, List<T> value)
		{
			return null;
		}

		// Token: 0x0601136D RID: 70509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601136D")]
		[Address(RVA = "0x919E20", Offset = "0x918A20", VA = "0x180919E20")]
		public static ParamKeyValue NewEmpty()
		{
			return null;
		}

		// Token: 0x0601136E RID: 70510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601136E")]
		[Address(RVA = "0x919D90", Offset = "0x918990", VA = "0x180919D90")]
		public static ParamKeyValue NewEmptyInvalid()
		{
			return null;
		}

		// Token: 0x0601136F RID: 70511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601136F")]
		[Address(RVA = "0x919EA0", Offset = "0x918AA0", VA = "0x180919EA0")]
		public static ParamKeyValue NewParamKeyValue(string key, ParamValue value)
		{
			return null;
		}

		// Token: 0x06011370 RID: 70512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011370")]
		[Address(RVA = "0x919F30", Offset = "0x918B30", VA = "0x180919F30")]
		public static ParamKeyValue NewParamKeyValue(KeyValuePair<string, ParamValue> pair)
		{
			return null;
		}

		// Token: 0x06011371 RID: 70513 RVA: 0x0006A170 File Offset: 0x00068370
		[Token(Token = "0x6011371")]
		public static bool TryParse<T>(string key, T value, out ParamKeyValue result)
		{
			return default(bool);
		}

		// Token: 0x06011372 RID: 70514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011372")]
		[Address(RVA = "0x919AE0", Offset = "0x9186E0", VA = "0x180919AE0")]
		public ParamKeyValue Duplicate(bool usePool = true)
		{
			return null;
		}

		// Token: 0x06011373 RID: 70515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011373")]
		[Address(RVA = "0x919AA0", Offset = "0x9186A0", VA = "0x180919AA0")]
		public ParamKeyValue DeepCopy()
		{
			return null;
		}

		// Token: 0x06011374 RID: 70516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011374")]
		[Address(RVA = "0x919A60", Offset = "0x918660", VA = "0x180919A60")]
		public void Clear()
		{
		}

		// Token: 0x06011375 RID: 70517 RVA: 0x0006A188 File Offset: 0x00068388
		[Token(Token = "0x6011375")]
		[Address(RVA = "0x919BA0", Offset = "0x9187A0", VA = "0x180919BA0", Slot = "4")]
		public bool Equals(ParamKeyValue other)
		{
			return default(bool);
		}

		// Token: 0x06011376 RID: 70518 RVA: 0x0006A1A0 File Offset: 0x000683A0
		[Token(Token = "0x6011376")]
		[Address(RVA = "0x919C10", Offset = "0x918810", VA = "0x180919C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06011377 RID: 70519 RVA: 0x0006A1B8 File Offset: 0x000683B8
		[Token(Token = "0x6011377")]
		[Address(RVA = "0x919D20", Offset = "0x918920", VA = "0x180919D20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401346B RID: 78955
		[Token(Token = "0x401346B")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x0401346C RID: 78956
		[Token(Token = "0x401346C")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public ParamValue value;
	}
}
