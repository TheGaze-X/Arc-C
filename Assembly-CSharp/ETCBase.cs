using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
[Serializable]
public abstract class ETCBase : MonoBehaviour
{
	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000CB RID: 203 RVA: 0x000023D0 File Offset: 0x000005D0
	// (set) Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001F")]
	public ETCBase.RectAnchor anchor
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
		get
		{
			return ETCBase.RectAnchor.UserDefined;
		}
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4FD560", Offset = "0x4FC160", VA = "0x1804FD560")]
		set
		{
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000CD RID: 205 RVA: 0x000023E8 File Offset: 0x000005E8
	// (set) Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000020")]
	public Vector2 anchorOffet
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4FD490", Offset = "0x4FC090", VA = "0x1804FD490")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4FD520", Offset = "0x4FC120", VA = "0x1804FD520")]
		set
		{
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000CF RID: 207 RVA: 0x00002400 File Offset: 0x00000600
	// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000021")]
	public bool visible
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4FD570", Offset = "0x4FC170", VA = "0x1804FD570")]
		set
		{
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002418 File Offset: 0x00000618
	// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000022")]
	public bool activated
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4FD4D0", Offset = "0x4FC0D0", VA = "0x1804FD4D0")]
		set
		{
		}
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x4FB410", Offset = "0x4FA010", VA = "0x1804FB410", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x4FD1B0", Offset = "0x4FBDB0", VA = "0x1804FD1B0", Slot = "5")]
	public virtual void Start()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x4FC220", Offset = "0x4FAE20", VA = "0x1804FC220", Slot = "6")]
	public virtual void OnEnable()
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x4FC120", Offset = "0x4FAD20", VA = "0x1804FC120")]
	private void OnDisable()
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x4FC080", Offset = "0x4FAC80", VA = "0x1804FC080")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x4FD2E0", Offset = "0x4FBEE0", VA = "0x1804FD2E0", Slot = "7")]
	public virtual void Update()
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x4FBC00", Offset = "0x4FA800", VA = "0x1804FBC00", Slot = "8")]
	public virtual void FixedUpdate()
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x4FBE10", Offset = "0x4FAA10", VA = "0x1804FBE10", Slot = "9")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
	protected virtual void UpdateControlState()
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
	protected virtual void SetVisible(bool forceUnvisible = true)
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
	protected virtual void SetActivated()
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x4FC2C0", Offset = "0x4FAEC0", VA = "0x1804FC2C0")]
	public void SetAnchorPosition()
	{
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x4FBC50", Offset = "0x4FA850", VA = "0x1804FBC50")]
	protected GameObject GetFirstUIElement(Vector2 position)
	{
		return null;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x4FB6B0", Offset = "0x4FA2B0", VA = "0x1804FB6B0")]
	protected void CameraSmoothFollow()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x4FB520", Offset = "0x4FA120", VA = "0x1804FB520")]
	protected void CameraFollow()
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x4FD260", Offset = "0x4FBE60", VA = "0x1804FD260")]
	private IEnumerator UpdateVirtualControl()
	{
		return null;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x4FBB80", Offset = "0x4FA780", VA = "0x1804FBB80")]
	private IEnumerator FixedUpdateVirtualControl()
	{
		return null;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
	protected virtual void DoActionBeforeEndOfFrame()
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x4FD330", Offset = "0x4FBF30", VA = "0x1804FD330")]
	protected ETCBase()
	{
	}

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x18")]
	protected RectTransform cachedRectTransform;

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x20")]
	protected Canvas cachedRootCanvas;

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x28")]
	public bool isUnregisterAtDisable;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x29")]
	private bool visibleAtStart;

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x2A")]
	private bool activatedAtStart;

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected ETCBase.RectAnchor _anchor;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected Vector2 _anchorOffet;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected bool _visible;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	protected bool _activated;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x3A")]
	public bool enableCamera;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x3C")]
	public ETCBase.CameraMode cameraMode;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x40")]
	public string camTargetTag;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x48")]
	public bool autoLinkTagCam;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x50")]
	public string autoCamTag;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x58")]
	public Transform cameraTransform;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x60")]
	public ETCBase.CameraTargetMode cameraTargetMode;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x64")]
	public bool enableWallDetection;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x68")]
	public LayerMask wallLayer;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x70")]
	public Transform cameraLookAt;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x78")]
	protected CharacterController cameraLookAtCC;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 followOffset;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x8C")]
	public float followDistance;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x90")]
	public float followHeight;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x94")]
	public float followRotationDamping;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x98")]
	public float followHeightDamping;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x9C")]
	public int pointId;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0xA0")]
	public bool enableKeySimulation;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0xA1")]
	public bool allowSimulationStandalone;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0xA2")]
	public bool visibleOnStandalone;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0xA4")]
	public ETCBase.DPadAxis dPadAxisCount;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0xA8")]
	public bool useFixedUpdate;

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0xB0")]
	private List<RaycastResult> uiRaycastResultCache;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0xB8")]
	private PointerEventData uiPointerEventData;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0xC0")]
	private EventSystem uiEventSystem;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0xC8")]
	public bool isOnDrag;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0xC9")]
	public bool isSwipeIn;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0xCA")]
	public bool isSwipeOut;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0xCB")]
	public bool showPSInspector;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0xCC")]
	public bool showSpriteInspector;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0xCD")]
	public bool showEventInspector;

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0xCE")]
	public bool showBehaviourInspector;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0xCF")]
	public bool showAxesInspector;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0xD0")]
	public bool showTouchEventInspector;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0xD1")]
	public bool showDownEventInspector;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0xD2")]
	public bool showPressEventInspector;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0xD3")]
	public bool showCameraInspector;

	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public enum ControlType
	{
		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		Joystick,
		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		TouchPad,
		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		DPad,
		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		Button
	}

	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public enum RectAnchor
	{
		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		UserDefined,
		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		BottomLeft,
		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		BottomCenter,
		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		BottonRight,
		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		CenterLeft,
		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		Center,
		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		CenterRight,
		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		TopLeft,
		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		TopCenter,
		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		TopRight
	}

	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public enum DPadAxis
	{
		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		Two_Axis,
		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		Four_Axis
	}

	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public enum CameraMode
	{
		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		Follow,
		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		SmoothFollow
	}

	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public enum CameraTargetMode
	{
		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		UserDefined,
		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		LinkOnTag,
		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		FromDirectActionAxisX,
		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		FromDirectActionAxisY
	}
}
