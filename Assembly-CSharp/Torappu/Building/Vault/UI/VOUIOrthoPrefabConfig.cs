using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A7B RID: 6779
	[Token(Token = "0x2001A7B")]
	[CreateAssetMenu(menuName = "Torappu/Building/UI/VOUIOrthoPrefabConfig")]
	[Serializable]
	public class VOUIOrthoPrefabConfig : ScriptableObject, IHotfixable
	{
		// Token: 0x0600AAD5 RID: 43733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAD5")]
		[Address(RVA = "0x32649C0", Offset = "0x32635C0", VA = "0x1832649C0")]
		public IEnumerator<VOUIPanel> GetOrthoCharPrefabs(BuildingEvent evt, VRoom.Object roomObject)
		{
			return null;
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAD6")]
		[Address(RVA = "0x3264AB0", Offset = "0x32636B0", VA = "0x183264AB0")]
		public IEnumerator<VOUIPanel> GetOrthoFurniPrefabs(BuildingEvent evt, VRoom.Object roomObject)
		{
			return null;
		}

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAD7")]
		[Address(RVA = "0x3264BA0", Offset = "0x32637A0", VA = "0x183264BA0")]
		public VOUIOrthoPrefabConfig()
		{
		}

		// Token: 0x0400A336 RID: 41782
		[Token(Token = "0x400A336")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VOUIPanel[] _orthoCharUIPrefs;

		// Token: 0x0400A337 RID: 41783
		[Token(Token = "0x400A337")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VOUIPanel[] _orthoFurniUIPrefs;

		// Token: 0x0400A338 RID: 41784
		[Token(Token = "0x400A338")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetOrthoCharPrefabs;

		// Token: 0x0400A339 RID: 41785
		[Token(Token = "0x400A339")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetOrthoFurniPrefabs;

		// Token: 0x0400A33A RID: 41786
		[Token(Token = "0x400A33A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
