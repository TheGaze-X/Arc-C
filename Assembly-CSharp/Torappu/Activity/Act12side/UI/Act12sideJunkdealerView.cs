using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA8 RID: 31400
	[Token(Token = "0x2007AA8")]
	public class Act12sideJunkdealerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BFCD RID: 180173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFCD")]
		[Address(RVA = "0x27DAB60", Offset = "0x27D9760", VA = "0x1827DAB60")]
		public void InitView(string activityId)
		{
		}

		// Token: 0x0602BFCE RID: 180174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFCE")]
		[Address(RVA = "0x27DACB0", Offset = "0x27D98B0", VA = "0x1827DACB0")]
		public void PlayJunkDealerDialog(int recyclePoint, bool isGacha)
		{
		}

		// Token: 0x0602BFCF RID: 180175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFCF")]
		[Address(RVA = "0x27DAF80", Offset = "0x27D9B80", VA = "0x1827DAF80")]
		private void _RenderDialog(string content)
		{
		}

		// Token: 0x0602BFD0 RID: 180176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFD0")]
		[Address(RVA = "0x27DB020", Offset = "0x27D9C20", VA = "0x1827DB020")]
		private void _RenderUiSpineFacial(Act12SideData.RecycleAnimationState animationState)
		{
		}

		// Token: 0x0602BFD1 RID: 180177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BFD1")]
		[Address(RVA = "0x27DB0C0", Offset = "0x27D9CC0", VA = "0x1827DB0C0")]
		private Act12SideData.RecycleDialogData _TryGenRecycleDialog(int recyclePoints, bool isGacha)
		{
			return null;
		}

		// Token: 0x0602BFD2 RID: 180178 RVA: 0x000DDDC0 File Offset: 0x000DBFC0
		[Token(Token = "0x602BFD2")]
		[Address(RVA = "0x27DAE60", Offset = "0x27D9A60", VA = "0x1827DAE60")]
		private Act12SideData.RecycleDialogType _GenRecycleType(int recyclePoints, bool isGacha)
		{
			return Act12SideData.RecycleDialogType.NONE;
		}

		// Token: 0x0602BFD3 RID: 180179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFD3")]
		[Address(RVA = "0x27DB2E0", Offset = "0x27D9EE0", VA = "0x1827DB2E0")]
		public Act12sideJunkdealerView()
		{
		}

		// Token: 0x0403FB7C RID: 260988
		[Token(Token = "0x403FB7C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12sideUISpineCharController _uiSpineController;

		// Token: 0x0403FB7D RID: 260989
		[Token(Token = "0x403FB7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _dialogText;

		// Token: 0x0403FB7E RID: 260990
		[Token(Token = "0x403FB7E")]
		[FieldOffset(Offset = "0x28")]
		private string m_activityId;

		// Token: 0x0403FB7F RID: 260991
		[Token(Token = "0x403FB7F")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Act12SideData.RecycleDialogType, List<Act12SideData.RecycleDialogData>> m_dialogDict;

		// Token: 0x0403FB80 RID: 260992
		[Token(Token = "0x403FB80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0403FB81 RID: 260993
		[Token(Token = "0x403FB81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayJunkDealerDialog;

		// Token: 0x0403FB82 RID: 260994
		[Token(Token = "0x403FB82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDialog;

		// Token: 0x0403FB83 RID: 260995
		[Token(Token = "0x403FB83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderUiSpineFacial;

		// Token: 0x0403FB84 RID: 260996
		[Token(Token = "0x403FB84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryGenRecycleDialog;

		// Token: 0x0403FB85 RID: 260997
		[Token(Token = "0x403FB85")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenRecycleType;

		// Token: 0x0403FB86 RID: 260998
		[Token(Token = "0x403FB86")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
