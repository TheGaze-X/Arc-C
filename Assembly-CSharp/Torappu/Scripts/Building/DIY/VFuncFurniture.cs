using System;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using UnityEngine;
using XLua;

namespace Torappu.Scripts.Building.DIY
{
	// Token: 0x020017B7 RID: 6071
	[Token(Token = "0x20017B7")]
	public class VFuncFurniture : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06009977 RID: 39287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001082")]
		public Transform btnPos
		{
			[Token(Token = "0x6009977")]
			[Address(RVA = "0x314E6E0", Offset = "0x314D2E0", VA = "0x18314E6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06009978 RID: 39288 RVA: 0x0003BA48 File Offset: 0x00039C48
		// (set) Token: 0x06009979 RID: 39289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001083")]
		public BuildingData.FurnitureSubType subType
		{
			[Token(Token = "0x6009978")]
			[Address(RVA = "0x314E970", Offset = "0x314D570", VA = "0x18314E970")]
			get
			{
				return BuildingData.FurnitureSubType.NONE;
			}
			[Token(Token = "0x6009979")]
			[Address(RVA = "0x314E9D0", Offset = "0x314D5D0", VA = "0x18314E9D0")]
			set
			{
			}
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600997A")]
		[Address(RVA = "0x314DEC0", Offset = "0x314CAC0", VA = "0x18314DEC0")]
		public void OpenFunctionPage()
		{
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600997B")]
		[Address(RVA = "0x314E3E0", Offset = "0x314CFE0", VA = "0x18314E3E0")]
		private void _TryOpenMessageLeavePage()
		{
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600997C")]
		[Address(RVA = "0x314E4E0", Offset = "0x314D0E0", VA = "0x18314E4E0")]
		private void _TryOpenMusicPlayerPage()
		{
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x0600997D RID: 39293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001084")]
		private ILODHolder lodHolder
		{
			[Token(Token = "0x600997D")]
			[Address(RVA = "0x314E740", Offset = "0x314D340", VA = "0x18314E740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600997E RID: 39294 RVA: 0x0003BA60 File Offset: 0x00039C60
		[Token(Token = "0x17001085")]
		protected bool lodVisible
		{
			[Token(Token = "0x600997E")]
			[Address(RVA = "0x314E7D0", Offset = "0x314D3D0", VA = "0x18314E7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600997F")]
		[Address(RVA = "0x314E680", Offset = "0x314D280", VA = "0x18314E680")]
		public VFuncFurniture()
		{
		}

		// Token: 0x04008FA6 RID: 36774
		[Token(Token = "0x4008FA6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _btnPos;

		// Token: 0x04008FA7 RID: 36775
		[Token(Token = "0x4008FA7")]
		[FieldOffset(Offset = "0x20")]
		private BuildingData.FurnitureSubType m_subType;

		// Token: 0x04008FA8 RID: 36776
		[Token(Token = "0x4008FA8")]
		[FieldOffset(Offset = "0x28")]
		private ILODHolder m_lodHolder;

		// Token: 0x04008FA9 RID: 36777
		[Token(Token = "0x4008FA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_btnPos;

		// Token: 0x04008FAA RID: 36778
		[Token(Token = "0x4008FAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_subType;

		// Token: 0x04008FAB RID: 36779
		[Token(Token = "0x4008FAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_subType;

		// Token: 0x04008FAC RID: 36780
		[Token(Token = "0x4008FAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenFunctionPage;

		// Token: 0x04008FAD RID: 36781
		[Token(Token = "0x4008FAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryOpenMessageLeavePage;

		// Token: 0x04008FAE RID: 36782
		[Token(Token = "0x4008FAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryOpenMusicPlayerPage;

		// Token: 0x04008FAF RID: 36783
		[Token(Token = "0x4008FAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_lodHolder;

		// Token: 0x04008FB0 RID: 36784
		[Token(Token = "0x4008FB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_lodVisible;

		// Token: 0x04008FB1 RID: 36785
		[Token(Token = "0x4008FB1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
