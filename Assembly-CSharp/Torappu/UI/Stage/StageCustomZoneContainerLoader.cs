using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200695E RID: 26974
	[Token(Token = "0x200695E")]
	public class StageCustomZoneContainerLoader : PageAssetPool<GameObject>
	{
		// Token: 0x060269BB RID: 158139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269BB")]
		[Address(RVA = "0x21AB7D0", Offset = "0x21AA3D0", VA = "0x1821AB7D0")]
		public StageCustomZoneContainer LoadContainer(string assetPath, Transform parent)
		{
			return null;
		}

		// Token: 0x060269BC RID: 158140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269BC")]
		private ContainerType _LoadContainer<ContainerType>(string assetPath, Transform parent) where ContainerType : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060269BD RID: 158141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269BD")]
		[Address(RVA = "0x21AB8D0", Offset = "0x21AA4D0", VA = "0x1821AB8D0")]
		public StageCustomZoneContainerLoader()
		{
		}

		// Token: 0x040367A1 RID: 223137
		[Token(Token = "0x40367A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadContainer;

		// Token: 0x040367A2 RID: 223138
		[Token(Token = "0x40367A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadContainer;

		// Token: 0x040367A3 RID: 223139
		[Token(Token = "0x40367A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
