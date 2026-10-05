using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006722 RID: 26402
	[Token(Token = "0x2006722")]
	public class HandBookV2GroupMapStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06025E02 RID: 155138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E02")]
		[Address(RVA = "0x20DE740", Offset = "0x20DD340", VA = "0x1820DE740")]
		public void ClearViewModel()
		{
		}

		// Token: 0x06025E03 RID: 155139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025E03")]
		[Address(RVA = "0x20DE7E0", Offset = "0x20DD3E0", VA = "0x1820DE7E0")]
		public string GetMainForceId()
		{
			return null;
		}

		// Token: 0x06025E04 RID: 155140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025E04")]
		[Address(RVA = "0x20DFB40", Offset = "0x20DE740", VA = "0x1820DFB40")]
		private static string _GetMainGroup(HandBookV2GroupViewModel viewModel)
		{
			return null;
		}

		// Token: 0x06025E05 RID: 155141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E05")]
		[Address(RVA = "0x20DF930", Offset = "0x20DE530", VA = "0x1820DF930")]
		public void InitViewModel(UIPage page, string forceId, bool isFromStack = false)
		{
		}

		// Token: 0x06025E06 RID: 155142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025E06")]
		[Address(RVA = "0x20DE4B0", Offset = "0x20DD0B0", VA = "0x1820DE4B0")]
		public List<HandBookV2GroupConnectViewModel> CheckConnectList(List<HandBookV2GroupCharViewModel> charList, List<HandBookV2GroupPosData.Connection> connectList)
		{
			return null;
		}

		// Token: 0x06025E07 RID: 155143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E07")]
		[Address(RVA = "0x20DE870", Offset = "0x20DD470", VA = "0x1820DE870")]
		public void InitViewModelByGroupId(UIPage page, string groupId, string forceId, string focusCharId, bool isFromStack = false)
		{
		}

		// Token: 0x06025E08 RID: 155144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E08")]
		[Address(RVA = "0x20DFD40", Offset = "0x20DE940", VA = "0x1820DFD40")]
		public HandBookV2GroupMapStateBean()
		{
		}

		// Token: 0x04035462 RID: 218210
		[Token(Token = "0x4035462")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2GroupProperty _property;

		// Token: 0x04035463 RID: 218211
		[Token(Token = "0x4035463")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ClearViewModel;

		// Token: 0x04035464 RID: 218212
		[Token(Token = "0x4035464")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMainForceId;

		// Token: 0x04035465 RID: 218213
		[Token(Token = "0x4035465")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetMainGroup;

		// Token: 0x04035466 RID: 218214
		[Token(Token = "0x4035466")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitViewModel;

		// Token: 0x04035467 RID: 218215
		[Token(Token = "0x4035467")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckConnectList;

		// Token: 0x04035468 RID: 218216
		[Token(Token = "0x4035468")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitViewModelByGroupId;

		// Token: 0x04035469 RID: 218217
		[Token(Token = "0x4035469")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
