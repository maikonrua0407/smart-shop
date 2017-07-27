UPDATE HT_THONG_TIN SET Value = (REPLACE(Value,'Media\Portal','Media'))
UPDATE SP_SAN_PHAM_TTINH SET GIA_TRI = (REPLACE(GIA_TRI,'Media\Portal','Media')) WHERE MA_TTINH LIKE '%_ANH%'
UPDATE Provider SET Logo = (REPLACE(Logo,'~/Administrator/tempProvider','~/Media/AdvImage/Provider'))