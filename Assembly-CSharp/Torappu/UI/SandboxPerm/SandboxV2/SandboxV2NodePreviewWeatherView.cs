using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004279 RID: 17017
	[Token(Token = "0x2004279")]
	public class SandboxV2NodePreviewWeatherView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A382 RID: 107394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A382")]
		[Address(RVA = "0x1321F70", Offset = "0x1320B70", VA = "0x181321F70")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601A383 RID: 107395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A383")]
		[Address(RVA = "0x1321DC0", Offset = "0x13209C0", VA = "0x181321DC0")]
		public void Render(string topicId, SandboxV2WeatherData weatherData)
		{
		}

		// Token: 0x0601A384 RID: 107396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A384")]
		[Address(RVA = "0x1321BD0", Offset = "0x13207D0", VA = "0x181321BD0")]
		public void CloseWeatherDetail()
		{
		}

		// Token: 0x0601A385 RID: 107397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A385")]
		[Address(RVA = "0x1321C40", Offset = "0x1320840", VA = "0x181321C40")]
		public void OnBtnWeatherDetailClicked()
		{
		}

		// Token: 0x0601A386 RID: 107398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A386")]
		[Address(RVA = "0x1321FF0", Offset = "0x1320BF0", VA = "0x181321FF0")]
		public GameObject TutorialOnly_GetStartBattleGo()
		{
			return null;
		}

		// Token: 0x0601A387 RID: 107399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A387")]
		[Address(RVA = "0x1322060", Offset = "0x1320C60", VA = "0x181322060")]
		public SandboxV2NodePreviewWeatherView()
		{
		}

		// Token: 0x04021312 RID: 135954
		[Token(Token = "0x4021312")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Weather Button")]
		private Image _weatherClassImage;

		// Token: 0x04021313 RID: 135955
		[Token(Token = "0x4021313")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Weather Button")]
		private Image _weatherIcon;

		// Token: 0x04021314 RID: 135956
		[Token(Token = "0x4021314")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Weather Button")]
		private Text _weatherType;

		// Token: 0x04021315 RID: 135957
		[Token(Token = "0x4021315")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Weather Button")]
		private Text _weatherName;

		// Token: 0x04021316 RID: 135958
		[Token(Token = "0x4021316")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Weather Button")]
		private Button _btnWeatherPreview;

		// Token: 0x04021317 RID: 135959
		[Token(Token = "0x4021317")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Weather Detail")]
		private SandboxV2NodePreviewWeatherFloatPanel _weatherFloatPanel;

		// Token: 0x04021318 RID: 135960
		[Token(Token = "0x4021318")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021319 RID: 135961
		[Token(Token = "0x4021319")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2WeatherData m_cachedWeatherData;

		// Token: 0x0402131A RID: 135962
		[Token(Token = "0x402131A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402131B RID: 135963
		[Token(Token = "0x402131B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0402131C RID: 135964
		[Token(Token = "0x402131C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseWeatherDetail;

		// Token: 0x0402131D RID: 135965
		[Token(Token = "0x402131D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnWeatherDetailClicked;

		// Token: 0x0402131E RID: 135966
		[Token(Token = "0x402131E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetStartBattleGo;

		// Token: 0x0402131F RID: 135967
		[Token(Token = "0x402131F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
