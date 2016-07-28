<?php

namespace Wms\HttpClient;

use Dddml\Executor\Http\CommandExecutor;
use Dddml\Executor\Http\AbstractCommandRequest;
use Dddml\Routing\RouteTrait;
use Symfony\Component\Routing\Route;
use Dddml\Serializer\Type\Long;
use Wms\Domain\DeletePermission;


class DeletePermissionRequest extends AbstractCommandRequest
{
    use RouteTrait;

    /**
     * @var DeletePermission
     */
    private $command;

    public static $commandType = 'Wms\Domain\DeletePermission';

    public function __construct(CommandExecutor $executor)
    {
        parent::__construct($executor);
        $this->route = new Route('Permissions/{id}');
    }

    public function getMethod()
    {
        return CommandExecutor::METHOD_DELETE;
    }

    /**
     * @return DeletePermission
     */
    public function getCommand()
    {
        if (!$this->command) {
            $this->command = new DeletePermission();
        }

        return $this->command;
    }

}

