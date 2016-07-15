﻿<?php

namespace Wms\HttpClient;

use Wms\Domain\UserRole;
use Wms\Domain\UserClaim;
use Wms\Domain\UserPermission;
use Wms\Domain\UserLogin;
use Wms\Domain\LoginKey;

class UserQueryRequest extends AbstractQueryRequest
{
    use UserFilteringFieldsTrait;

    protected $routePath = 'Users/{id}';

    public function getReturnType()
    {
        return 'Wms\Domain\User';
    }
}
