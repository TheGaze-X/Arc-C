using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.SDK
{
	// Token: 0x020014EF RID: 5359
	[Token(Token = "0x20014EF")]
	[CreateAssetMenu(menuName = "Torappu/SDK/SDKHolder")]
	public class SDKHolder : SingletonScriptableObject<SDKHolder>
	{
		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06007B83 RID: 31619 RVA: 0x000371A0 File Offset: 0x000353A0
		// (set) Token: 0x06007B84 RID: 31620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EB2")]
		[Inspect]
		public SDKType type
		{
			[Token(Token = "0x6007B83")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return SDKType.NONE;
			}
			[Token(Token = "0x6007B84")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB3")]
		public GameObject SDKObj
		{
			[Token(Token = "0x6007B85")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B86")]
		[Address(RVA = "0x2743840", Offset = "0x2742440", VA = "0x182743840")]
		public static ISDKBase FindSDKComponent(GameObject obj)
		{
			return null;
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B87")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void _SetSDKTypeAndSave(SDKType targetType)
		{
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B88")]
		[Address(RVA = "0x2743A80", Offset = "0x2742680", VA = "0x182743A80")]
		public SDKHolder()
		{
		}

		// Token: 0x040079DE RID: 31198
		[Token(Token = "0x40079DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		[Group("Status")]
		private SDKType _curType;

		// Token: 0x040079DF RID: 31199
		[Token(Token = "0x40079DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		[Group("Status")]
		private GameObject _curSDKObj;

		// Token: 0x040079E0 RID: 31200
		[Token(Token = "0x40079E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("The target game object must have a component of SDKBase")]
		private List<SDKHolder.SDKConfig> _SDKs;

		// Token: 0x020014F0 RID: 5360
		[Token(Token = "0x20014F0")]
		[Serializable]
		public struct SDKConfig
		{
			// Token: 0x040079E1 RID: 31201
			[Token(Token = "0x40079E1")]
			[FieldOffset(Offset = "0x0")]
			public SDKType type;

			// Token: 0x040079E2 RID: 31202
			[Token(Token = "0x40079E2")]
			[FieldOffset(Offset = "0x8")]
			public string assetPath;
		}
	}
}
